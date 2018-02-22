using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp;
using PostSharp.Aspects;
using System.Diagnostics;
using NPP.Utils;

namespace NPP.Aspects
{
    [Serializable]
    public class LogAspect: OnMethodBoundaryAspect
    {
        public override sealed void OnEntry(MethodExecutionArgs args)
        {
            Logger.Instance.Info(String.Format("Entering method [ {0} ] ...", args.Method));

            base.OnEntry(args);
        }

        public override sealed void OnExit(MethodExecutionArgs args)
        {
            Logger.Instance.Info(String.Format("Leaving method [ {0} ] ...", args.Method));

            base.OnExit(args);
        }
    }
}
