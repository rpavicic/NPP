using PostSharp.Aspects;
using PostSharp.Extensibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.Aspects
{
    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method)]
    public class TimingAspect: OnMethodBoundaryAspect
    {
        [NonSerialized]
        Stopwatch _StopWatch;

        public override void OnEntry(PostSharp.Aspects.MethodExecutionArgs args)
        {
            _StopWatch = Stopwatch.StartNew();

            base.OnEntry(args);
        }

        public override void OnExit(PostSharp.Aspects.MethodExecutionArgs args)
        {
            Debug.WriteLine(string.Format("[{0}] took {1}ms to execute",
              new StackTrace().GetFrame(1).GetMethod().Name,
                _StopWatch.ElapsedMilliseconds));

            base.OnExit(args);
        }
    }
}
