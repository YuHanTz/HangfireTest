using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using MySchedulerProject.Jobs;

namespace MyBackendService
{
    public class JobScheduler
    {
        private readonly IConfiguration configuration;
        private readonly IServiceProvider serviceProvider;

        public JobScheduler(IConfiguration _configuration, IServiceProvider _serviceProvider)
        {
            configuration = _configuration;
            serviceProvider = _serviceProvider;
        }

        public void ScheduleJobs()
        {
            var jobs = configuration.GetSection("Jobs").Get<List<ScheduledJob>>();

            if (jobs != null)
            {
                foreach (var job in jobs)
                {
                    if (job.Name == "SampleJob")
                    {
                        RecurringJob.AddOrUpdate<SampleJob>(
                            job.Name,
                            x => x.Run(),
                            job.CronExpression
                        );
                    }
                }
            }


        }



    }

    public class ScheduledJob
    {
        public string Name { get; set; } = string.Empty;
        public string CronExpression { get; set; } = string.Empty;
    }
}