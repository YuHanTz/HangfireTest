using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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




    }
}