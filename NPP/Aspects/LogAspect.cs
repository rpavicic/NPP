using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp;
using PostSharp.Aspects;
using System.Diagnostics;

namespace NPP.Aspects
{
    [Serializable]
    public class LogAspect: OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Debug.WriteLine(Environment.NewLine);
            Debug.WriteLine("Entering method [ {0} ] ...", args.Method);

            base.OnEntry(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Debug.WriteLine("Leaving method [ {0} ] ...", args.Method);

            base.OnExit(args);
        }
    }
}
