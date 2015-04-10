using CoinS2Machine.Core.Logging;
using Dlp.Framework.Container;
using Dlp.Framework.Container.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Interceptors {

    public class LogInterceptor : IInterceptor {

        public void Intercept(IInvocation invocation) {

            if (invocation.MethodInvocationTarget.Name == "WriteLog" && invocation.Arguments.Length == 1) {

                Log log = (Log)invocation.Arguments[0];

                log.MethodName = "Intercepted: " + log.MethodName;

                invocation.Arguments[0] = log;
            }

            invocation.Proceed();
        }
    }
}
