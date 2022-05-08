using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Egamek_Core;
using Egamek_Data.DAL;

namespace Egamek_Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
       


        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
