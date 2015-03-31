﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Processors {

    public class BillProcessor : AbstractProcessor {

        public BillProcessor() { }

        public override string GetName() {
            return "Bill Processor";
        }

        public override long[] GetAvailableValues() {
            return new long[] { 10000, 5000, 2000, 1000, 500, 200 };
        }

        public override DataContracts.CashType CashType {
            get {
                return DataContracts.CashType.Bill;
            }
        }
    }
}
