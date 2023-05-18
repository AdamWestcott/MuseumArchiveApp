using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IProvenanceRecordRepository
    {
        public Task<ProvenanceRecordDTO> CreateProvenanceRecord(ProvenanceRecordDTO provenanceRecordDTO);
        public Task<ProvenanceRecordDTO> UpdateProvenanceRecord(string ProvenancRecordId, ProvenanceRecordDTO provenanceRecordDTO);
        public Task<ProvenanceRecordDTO> GetProvenanceRecord(string ProvenancRecordId);
        public Task<string> DeleteProvenanceRecord(string ProvenancRecordId);
        public Task<IEnumerable<ProvenanceRecordDTO>> GetAllProvenanceRecords();
        public Task<IEnumerable<ProvenanceRecordDTO>> GetAllProvenanceRecordsByProvidenceID(string providenceId);
        public Task<ProvenanceRecordDTO> IsProvenanceRecordUnique(string ProvenanceRecordName);
    }
}
