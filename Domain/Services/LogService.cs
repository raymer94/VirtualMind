﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface LogService
    {
        public Task<IEnumerable<Log>> GetLogs();
        public Task<Log> GetLogById(int logId);
        public Task CreateOrEditLog(Log log);
        public Task DeleteLog(int logId);
    }
}
