using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Processors {

    public static class ProcessorFactory {

        public static AbstractProcessor Create(long changeAmount) {

            // Lista de todos os processadores disponíveis.
            AbstractProcessor[] processorList = new AbstractProcessor[] {
                new BillProcessor(),
                new CoinProcessor()

                // TODO: Adicionar novos processadores acima desta linha.
            };

            // Organiza a lista de processadores, onde os processadores com maior valor mínimo estão na frente.
            processorList = processorList.OrderByDescending(p => p.GetAvailableValues().Min()).ToArray();

            // Verifica cada processador disponível para encontrar aquele capaz de processar o troco.
            foreach (AbstractProcessor processor in processorList) {

                if (processor.GetAvailableValues().Min() <= changeAmount) { return processor; }
            }

            return null;
        }
    }
}
