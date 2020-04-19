
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Web.Scheduling;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Scheduling
{
    //lots of good examples in core - https://github.com/umbraco/Umbraco-CMS/tree/v8/contrib/src/Umbraco.Web/Scheduling HealthCheckNotifier, ScheduledPublishing etc
    public class ScheduledLogger : RecurringTaskBase
    {
        private IRuntimeState _runtime;
        private IProfilingLogger _logger;

        public ScheduledLogger(IBackgroundTaskRunner<RecurringTaskBase> runner, int delayBeforeWeStart, int howOftenWeRepeat, IRuntimeState runtime, IProfilingLogger logger)
            : base(runner, delayBeforeWeStart, howOftenWeRepeat)
        {
            _runtime = runtime;
            _logger = logger;
        }

        public override bool PerformRun()
        {
          _logger.Info<ScheduledLogger>("The scheduler has ran");
          return true;
        }

        public override bool IsAsync { get; }
    }
}