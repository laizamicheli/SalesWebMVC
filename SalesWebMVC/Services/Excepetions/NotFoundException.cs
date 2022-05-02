using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Excepetions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message): base(message)
        {

        }
    }
}
