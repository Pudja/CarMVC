using Microsoft.EntityFrameworkCore;
using Pudja.VeichleDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pudja.VeichleDB.Services
{
    public class VMakeServices : IVMakeServices
    {
        private readonly VDbContext _db;

        public VMakeServices(VDbContext db)
        {
            _db = db;
        }

        public async Task<VMake[]> GetIncompleteItemsAsync()
        {
            return await _db.Makes.ToArrayAsync();
        }

        public async Task<bool> AddItemAsync(VMake newMake)
        {
            _db.Makes.Add(newMake);
            var saveResult = await _db.SaveChangesAsync();
                        
            return saveResult == 1;
        }

    }
}
