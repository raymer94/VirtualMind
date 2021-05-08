using Domain.Models;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainBuilt_in.Services
{
    public class BuiltInLogService : LogService
    {
        private ILogRepository logRepository;
        public BuiltInLogService(ILogRepository _logRepository)
        {
            this.logRepository = _logRepository;
        }

        public Task CreateOrEditLog(Log log)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteLog(int logId)
        {
            if (logId == 0)
            {
                throw new Exception("Must provide a log id");
            }

            var log = await logRepository.GetLogById(logId);
            if (log == null)
            {
                throw new Exception("You must specify a valid log id");
            }
        }

        public async Task<Log> GetLogById(int logId)
        {
            if (logId == 0)
            {
                throw new Exception("Must provide a log id");
            }

            var log = await logRepository.GetLogById(logId);
            if (log == null)
            {
                throw new Exception("You must specify a valid log id");
            }
            return log;
        }

        public Task<IEnumerable<Log>> GetLogs()
        {
            throw new NotImplementedException();
        }
    }
}
