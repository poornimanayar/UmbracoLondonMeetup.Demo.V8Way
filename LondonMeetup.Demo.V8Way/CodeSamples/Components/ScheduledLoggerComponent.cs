using System;
using LondonMeetup.Demo.V8Way.CodeSamples.Scheduling;
using Umbraco.Core.Composing;
using Umbraco.Core.Logging;
using Umbraco.Web.Scheduling;

namespace LondonMeetup.Demo.V8Way.CodeSamples.Components
{
    public class ScheduledLoggerComponent : IComponent
    {
        private readonly ILogger _logger;

        //background task runner is what actually runs a task, you define a background task runner, create a recurring task and add the recurring task to the task runner
        private BackgroundTaskRunner<IBackgroundTask> _loggerRunner;

        public ScheduledLoggerComponent(ILogger logger)
        {
            _logger = logger;
            _loggerRunner = new BackgroundTaskRunner<IBackgroundTask>("Scheduled Logger", _logger);
        }

        public void Initialize()
        {
            int delayBeforeWeStart = 60000; // 60000ms = 1min
            int howOftenWeRepeat = 300000; //300000ms = 5mins

            var task = new ScheduledLogger(_loggerRunner, delayBeforeWeStart, howOftenWeRepeat, _logger);

            // you can also call events on background task runners
            _loggerRunner.TaskCompleted += Task_Completed;

            _loggerRunner.TaskStarting += this.Task_Starting;

            _loggerRunner.TaskCancelled += this.Task_Cancelled;

            _loggerRunner.TaskError += this.Task_Error;

            //As soon as we add our task to the runner it will start to run (after its delay period)
            _loggerRunner.TryAdd(task);
        }

        private void Task_Error(BackgroundTaskRunner<IBackgroundTask> sender, TaskEventArgs<IBackgroundTask> e)
        {
            _logger.Info<ScheduledLoggerComponent>("Scheduled Logger error");
        }

        private void Task_Cancelled(BackgroundTaskRunner<IBackgroundTask> sender, TaskEventArgs<IBackgroundTask> e)
        {
            _logger.Info<ScheduledLoggerComponent>("Scheduled Logger cancelled");
        }

        private void Task_Starting(BackgroundTaskRunner<IBackgroundTask> sender, TaskEventArgs<IBackgroundTask> e)
        {
            _logger.Info<ScheduledLoggerComponent>("Scheduled Logger starting");
        }

        private void Task_Completed(BackgroundTaskRunner<IBackgroundTask> sender, TaskEventArgs<IBackgroundTask> e)
        {
           _logger.Info<ScheduledLoggerComponent>("Scheduled Logger run finished");
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}