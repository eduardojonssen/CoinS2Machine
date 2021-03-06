﻿using CoinS2Machine.Core.DataContracts;
using CoinS2Machine.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinS2Machine.Core.Logging;
using CoinS2Machine.Core.Utility;
using Dlp.Framework.Container;
using CoinS2Machine.Core.Interceptors;

namespace CoinS2Machine.Core {
    public class CoinS2MachineManager {

        public CoinS2MachineManager() {

            IocFactory.Register(
                Component.FromThisAssembly("CoinS2Machine.Core.Utility")
            );

            IocFactory.Register(

                Component.For<ILog>()
                    .ImplementedBy<FileLog>("FileLog")
                    .ImplementedBy<EventViewerLog>("EventViewerLog")
                    .ResolveDependencies()
            );

            LogFactory logFactory = new LogFactory();
            
            this.Logger = new Logger(logFactory.Create());
        }

        public Logger Logger { get; set; }

        public CalculateChangeResponse CalculateChange(CalculateChangeRequest calculateChangeRequest) {

            this.Logger.WriteLog("CalculateChange", LogType.Request, calculateChangeRequest);

            CalculateChangeResponse calculateChangeResponse = new CalculateChangeResponse();

            try {

                if (calculateChangeRequest.IsValid == false) {
                    calculateChangeResponse.OperationReportList = calculateChangeRequest.OperationReportList;
                    this.Logger.WriteLog("CalculateChange", LogType.Response, calculateChangeResponse);
                    return calculateChangeResponse;
                }

                // Obtém o valor total do troco a ser retornado.
                long actualChangeResult = calculateChangeRequest.PaidAmount - calculateChangeRequest.ProductAmount;

                long remainingChangeAmount = actualChangeResult;

                while (remainingChangeAmount > 0) {

                    // TODO: Implementar lógica.
                    AbstractProcessor processor = ProcessorFactory.Create(remainingChangeAmount);

                    if (processor == null) {
                        OperationReport operationReport = new OperationReport();

                        operationReport.FieldName = null;
                        operationReport.Message = "Valor não suportado. Por favor, tente novamente mais tarde.";
                        calculateChangeResponse.OperationReportList.Add(operationReport);
                        this.Logger.WriteLog("CalculateChange", LogType.Response, calculateChangeResponse);
                        return calculateChangeResponse;
                    }

                    List<ChangeData> changeDataList = processor.Calculate(remainingChangeAmount);

                    if (changeDataList.Any() == true) {

                        remainingChangeAmount -= changeDataList.Sum(c => c.UnitAmount * c.UnitCount);

                        foreach (ChangeData changeData in changeDataList.Where(p => p.UnitCount > 0)) {
                            calculateChangeResponse.ChangeDictionary.Add(new Cash(changeData.UnitCount, changeData.UnitAmount.ToString(), processor.CashType), changeData.UnitCount);
                        }
                    }
                }

                calculateChangeResponse.ChangeAmount = actualChangeResult;

            }
            catch (Exception ex) {
                this.Logger.WriteLog("CalculateChange", LogType.Error, ex.ToString());

                OperationReport operationReport = new OperationReport();

                operationReport.FieldName = null;
                operationReport.Message = "Não foi possível processar sua requisição. Por favor, tente novamente mais tarde.";

                calculateChangeResponse.OperationReportList.Add(operationReport);
            }

            this.Logger.WriteLog("CalculateChange", LogType.Response, calculateChangeResponse);
            return calculateChangeResponse;
        }
    }
}
