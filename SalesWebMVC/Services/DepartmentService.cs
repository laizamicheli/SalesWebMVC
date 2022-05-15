using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMVCContext _context;
        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List <Department>> FindAllAsinc()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
