using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface JsonWebTokenService
    {
        public void Sign();
        public void Verify(string token);
    }
}
