using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pudja.VeichleDB.Models;

namespace Pudja.VeichleDB.Services
{
    public interface IVModelServices
    {
        Task<VModel[]> GetIncompleteItemsAsync();

        Task<bool> AddItemAsync(VModel newModel);
    }
}
