using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IArchivalItemRepository
    {
        public Task<ArchivalItemDTO> CreateArchivalItem(ArchivalItemDTO archivalItemDTO);
        public Task<ArchivalItemDTO> UpdateArchivalItem(string archivalItemId, ArchivalItemDTO archivalItemDTO);
        public Task<ArchivalItemDTO> GetArchivalItem(string archivalItemId);
        public Task<string> DeleteArchivalItem(string archivalItemId);
        public Task<IEnumerable<ArchivalItemDTO>> GetAllArchivalItems();
        public Task<ArchivalItemDTO> IsArchivalItemUnique(string ArchivalItemName);
    }
}
