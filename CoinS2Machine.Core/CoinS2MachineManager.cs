using CoinS2Machine.Core.DataContracts;
using CoinS2Machine.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core {
    public class CoinS2MachineManager {

        public CoinS2MachineManager() { }

        public CalculateChangeResponse CalculateChange(CalculateChangeRequest calculateChangeRequest) {

            CalculateChangeResponse calculateChangeResponse = new CalculateChangeResponse();

            try {

                if (calculateChangeRequest.IsValid == false) {
                    calculateChangeResponse.OperationReportList = calculateChangeRequest.OperationReportList;
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
                        return calculateChangeResponse;
                    }

                    Dictionary<long, long> calculateResult = processor.Calculate(remainingChangeAmount);

                    if (calculateResult.Any() == true) {

                        remainingChangeAmount -= calculateResult.Sum(c => c.Key * c.Value);

                        foreach (KeyValuePair<long, long> item in calculateResult) {
                            calculateChangeResponse.CoinDictionary.Add(new Cash(item.Value, item.Key.ToString(), processor.CashType), item.Value);
                        }
                    }

                }

                calculateChangeResponse.ChangeAmount = actualChangeResult;

            }
            catch (Exception ex) {

                // TODO: Log da exceção.

                OperationReport operationReport = new OperationReport();

                operationReport.FieldName = null;
                operationReport.Message = "Não foi possível processar sua requisição. Por favor, tente novamente mais tarde.";

                calculateChangeResponse.OperationReportList.Add(operationReport);
            }

            return calculateChangeResponse;
        }

    }
}
