using CoinS2Machine.Core.Utility;
using Dlp.Framework.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Logging {

    public abstract class AbstractLog {

        public AbstractLog() {

            this.ConfigurationUtility = IocFactory.Resolve<IConfigurationUtility>();
        }

        public IConfigurationUtility ConfigurationUtility { get; set; }
    }
}
