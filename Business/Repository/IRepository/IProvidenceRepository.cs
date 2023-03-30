using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IProvidenceRepository
    {
        public Task<ProvidenceDTO> CreateProvidence(ProvidenceDTO providenceDTO);
        public Task<ProvidenceDTO> UpdateProvidence(string providenceId, ProvidenceDTO providenceDTO);
        public Task<ProvidenceDTO> GetProvidence(string providenceId);
        public Task<string> DeleteProvidence(string providenceId);
        public Task<IEnumerable<ProvidenceDTO>> GetAllProvidences();
        public Task<IEnumerable<ProvidenceDTO>> GetAllProvidencesByArchivalItemID(string archivalItemId);
        public Task<ProvidenceDTO> IsArchivalItemUnique(string providenceemName);
    }
}
