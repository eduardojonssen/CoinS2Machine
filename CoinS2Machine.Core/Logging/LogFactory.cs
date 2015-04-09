using CoinS2Machine.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Logging {
    public class LogFactory {

        private IConfigurationUtility configurationUtility;
        public IConfigurationUtility ConfigurationUtility {
            get {
                if (this.configurationUtility == null) { this.configurationUtility = new ConfigurationUtility(); }
                return this.configurationUtility;
            }
            set { this.configurationUtility = value; }
        }
        public ILog Create(IConfigurationUtility configurationUtility = null) {
            if (configurationUtility != null) {
                this.ConfigurationUtility = configurationUtility;
            }
            return this.Create(this.ConfigurationUtility.LogTypeName);
        }

        public ILog Create(string logName) {

            switch (logName) {

                case "FileLog":
                    return new FileLog(this.ConfigurationUtility);
                case "EventViewerLog":
                    return new EventViewerLog(this.ConfigurationUtility);
                default:
                    throw new NotSupportedException("Necessário especificar o tipo de log");
            }
        }
    }
}
