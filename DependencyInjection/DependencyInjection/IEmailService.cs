using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal interface IEmailService
    {
      
            void Send(string message);
        
    }
}
