using CoinS2Machine.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Logging {
    public abstract class AbstractLog {
        public AbstractLog(IConfigurationUtility configurationUtility = null) {

            this.ConfigurationUtility = configurationUtility;            
        }

        private IConfigurationUtility configurationUtility;
        protected IConfigurationUtility ConfigurationUtility {
            get {
                if (this.configurationUtility == null) { this.configurationUtility = new ConfigurationUtility(); }
                return this.configurationUtility;
            }
            set { this.configurationUtility = value; }
        }
    }
}
