using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pudja.VeichleDB.Models;

namespace Pudja.VeichleDB.Services
{
    public interface IVMakeServices
    {
        Task<VMake[]> GetIncompleteItemsAsync();

        Task<bool> AddItemAsync(VMake newMake);
    }
}