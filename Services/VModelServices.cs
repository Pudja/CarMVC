using Microsoft.EntityFrameworkCore;
using Pudja.VeichleDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pudja.VeichleDB.Services
{
    public class VModelServices : IVModelServices
    {

        private readonly VDbContext _db;

        public VModelServices(VDbContext db)
        {
            _db = db;
        }

        public async Task<VModel[]> GetIncompleteItemsAsync()
        {
            return await _db.Models.ToArrayAsync();
        }

        public async Task<bool> AddItemAsync(VModel newModel)
        {
            _db.Models.Add(newModel);
            var saveResult = await _db.SaveChangesAsync();

            return saveResult == 1;
        }
    }
}
