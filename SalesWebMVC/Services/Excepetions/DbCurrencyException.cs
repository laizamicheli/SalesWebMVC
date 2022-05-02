using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Excepetions
{
    public class DbCurrencyException: ApplicationException
    {
        public DbCurrencyException(string message): base(message)
        {
            
        }
    }
}
