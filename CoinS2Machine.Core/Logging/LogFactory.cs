using CoinS2Machine.Core.Utility;
using Dlp.Framework.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Logging {
    public class LogFactory {

        public ILog Create() {

            // Obter uma instancia do configurationUtility.
            IConfigurationUtility configurationUtility = IocFactory.Resolve<IConfigurationUtility>();

            return IocFactory.ResolveByName<ILog>(configurationUtility.LogTypeName);
        }
    }
}
