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
    public class ProvidenceRepository : IProvidenceRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ProvidenceRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProvidenceDTO> CreateProvidence(ProvidenceDTO providenceDTO)
        {
            Providences providence = _mapper.Map<ProvidenceDTO, Providences>(providenceDTO);
            var addedProvidence = await _db.Providences.AddAsync(providence);
            await _db.SaveChangesAsync();
            return _mapper.Map<Providences, ProvidenceDTO>(addedProvidence.Entity);
        }

        public async Task<string> DeleteProvidence(string providenceID)
        {
            var providenceDetails = await _db.Providences.FindAsync(providenceID);
            if (providenceDetails != null)
            {
                _db.Providences.Remove(providenceDetails);
                await _db.SaveChangesAsync();
                return "Done";
            }

            return "Done";

        }

        public async Task<IEnumerable<ProvidenceDTO>> GetAllProvidences()
        {
            try
            {
                IEnumerable<ProvidenceDTO> providenceDTOS =
                    _mapper.Map<IEnumerable<Providences>, IEnumerable<ProvidenceDTO>>(_db.Providences);
                return providenceDTOS;

            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<ProvidenceDTO>> GetAllProvidencesByArchivalItemID(string archivalItemID)
        {
            List<ProvidenceDTO> result = new List<ProvidenceDTO>();
            List<Providences> providences = _db.Providences.Where(x => x.ArchivalItemID == archivalItemID).ToList();
            result = _mapper.Map<List<ProvidenceDTO>>(providences);
            return await Task.FromResult(result);
        }

        public async Task<ProvidenceDTO> GetProvidence(string providenceID)
        {
            try
            {
                ProvidenceDTO providence = _mapper.Map<Providences, ProvidenceDTO>(
                await _db.Providences.FirstOrDefaultAsync(x => x.Id == providenceID));

                return providence;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ProvidenceDTO> IsProvidenceUnique(string name)
        {
            try
            {
                ProvidenceDTO providence = _mapper.Map<Providences, ProvidenceDTO>(
                await _db.Providences.FirstOrDefaultAsync(x => x.ProvidenceName.ToLower() == name.ToLower()));

                return providence;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ProvidenceDTO> UpdateProvidence(string providenceID, ProvidenceDTO providenceDTO)
        {
            try
            {
                if (providenceID == providenceDTO.Id)
                {
                    //valid
                    Providences providenceDetails = await _db.Providences.FindAsync(providenceID);
                    Providences providence = _mapper.Map<ProvidenceDTO, Providences>(providenceDTO, providenceDetails);
                    var updatedEmployee = _db.Providences.Update(providence);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Providences, ProvidenceDTO>(updatedEmployee.Entity);
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
