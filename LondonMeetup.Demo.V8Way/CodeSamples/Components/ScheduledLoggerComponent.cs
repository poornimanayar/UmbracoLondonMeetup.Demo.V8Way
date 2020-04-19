using System;
using LondonMeetup.Demo.V8Way.CodeSamples.Scheduling;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Web.Scheduling;
using IComponent = Umbraco.Core.Composing.IComponent;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class ScheduledLoggerComponent : IComponent
    {
        private IProfilingLogger _logger;
        private IRuntimeState _runtime;
        private BackgroundTaskRunner<IBackgroundTask> _loggerRunner;

        public ScheduledLoggerComponent(IProfilingLogger logger, IRuntimeState runtime)
        {
            _logger = logger;
            _runtime = runtime;
            _loggerRunner = new BackgroundTaskRunner<IBackgroundTask>("Scheduled Logger", _logger);
        }

        public void Initialize()
        {
            int delayBeforeWeStart = 60000; // 60000ms = 1min
            int howOftenWeRepeat = 300000; //300000ms = 5mins

            var task = new ScheduledLogger(_loggerRunner, delayBeforeWeStart, howOftenWeRepeat, _runtime, _logger);

            //As soon as we add our task to the runner it will start to run (after its delay period)
            _loggerRunner.TryAdd(task);
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}