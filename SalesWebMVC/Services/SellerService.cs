﻿using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Services.Excepetions;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;
        
        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
             return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync (Seller obj)
        {
            _context.Add(obj);
           await _context.SaveChangesAsync();
        }
        public async Task <Seller> FindByIdAsync (int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj =await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsinc(Seller obj)
        {
            bool hasAsync = await _context.Seller.AnyAsync(x => x.Id == obj.Id))
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");

            }
            try 
            {
                _context.Update(obj);
               await _context.SaveChangesAsync();
            }
            catch(DbCurrencyException e)
            {
                throw new DbCurrencyException(e.Message);
            }
        }

    }
}
