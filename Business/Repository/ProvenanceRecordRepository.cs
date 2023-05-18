using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class ProvenanceRecordRepository : IProvenanceRecordRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ProvenanceRecordRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProvenanceRecordDTO> CreateProvenanceRecord(ProvenanceRecordDTO provenanceRecordDTO)
        {
            ProvenanceRecord provenanceRecord = _mapper.Map<ProvenanceRecordDTO, ProvenanceRecord>(provenanceRecordDTO);
            var addedProvidence = await _db.ProvenanceRecords.AddAsync(provenanceRecord);
            await _db.SaveChangesAsync();
            return _mapper.Map<ProvenanceRecord, ProvenanceRecordDTO>(addedProvidence.Entity);
        }

        public async Task<string> DeleteProvenanceRecord(string provenanceRecordID)
        {
            var provenanceRecordDetails = await _db.ProvenanceRecords.FindAsync(provenanceRecordID);
            if (provenanceRecordDetails != null)
            {
                _db.ProvenanceRecords.Remove(provenanceRecordDetails);
                await _db.SaveChangesAsync();
                return "Done";
            }

            return "Done";

        }

        public async Task<IEnumerable<ProvenanceRecordDTO>> GetAllProvenanceRecords()
        {
            try
            {
                IEnumerable<ProvenanceRecordDTO> provenanceRecordDTOS =
                    _mapper.Map<IEnumerable<ProvenanceRecord>, IEnumerable<ProvenanceRecordDTO>>(_db.ProvenanceRecords);
                return provenanceRecordDTOS;

            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<ProvenanceRecordDTO>> GetAllProvenanceRecordsByProvidenceID(string providenceID)
        {
            List<ProvenanceRecordDTO> result = new List<ProvenanceRecordDTO>();
            List<ProvenanceRecord> provenanceRecords = _db.ProvenanceRecords.Where(x => x.ProvidenceID == providenceID).ToList();
            result = _mapper.Map<List<ProvenanceRecordDTO>>(provenanceRecords);
            return await Task.FromResult(result);
        }

        public async Task<ProvenanceRecordDTO> GetProvenanceRecord(string provenanceRecordID)
        {
            try
            {
                ProvenanceRecordDTO provenanceRecord = _mapper.Map<ProvenanceRecord, ProvenanceRecordDTO>(
                await _db.ProvenanceRecords.FirstOrDefaultAsync(x => x.Id == provenanceRecordID));

                return provenanceRecord;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ProvenanceRecordDTO> IsProvenanceRecordUnique(string name)
        {
            try
            {
                ProvenanceRecordDTO provenanceRecord = _mapper.Map<ProvenanceRecord, ProvenanceRecordDTO>(
                await _db.ProvenanceRecords.FirstOrDefaultAsync(x => x.ProvenanceName.ToLower() == name.ToLower()));

                return provenanceRecord;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ProvenanceRecordDTO> UpdateProvenanceRecord(string provenanceRecordID, ProvenanceRecordDTO provenanceRecordDTO)
        {
            try
            {
                if (provenanceRecordID == provenanceRecordDTO.Id)
                {
                    //valid
                    ProvenanceRecord provenanceRecorDetails = await _db.ProvenanceRecords.FindAsync(provenanceRecordID);
                    ProvenanceRecord provenanceRecor = _mapper.Map<ProvenanceRecordDTO, ProvenanceRecord>(provenanceRecordDTO, provenanceRecorDetails);
                    var updatedEmployee = _db.ProvenanceRecords.Update(provenanceRecor);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<ProvenanceRecord, ProvenanceRecordDTO>(updatedEmployee.Entity);
                }
                else
                {
                    //invalid
                    return null;
                }
            }

            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
