using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface HttpService<T>
    {
        public IEnumerable<T> Get(string baseUrl);
    }
}
