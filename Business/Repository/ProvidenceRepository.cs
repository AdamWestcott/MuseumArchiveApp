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
    public class ProvidenceRepository: IProvidenceRepository
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

        public async Task<string> DeleteArchivalItem(string archivalItemId)
        {
            var archivalItemDetails = await _db.ArchivalItems.FindAsync(archivalItemId);
            if (archivalItemDetails != null)
            {
                _db.ArchivalItems.Remove(archivalItemDetails);
                await _db.SaveChangesAsync();
                return "Done";
            }

            return "Done";

        }

        public async Task<IEnumerable<ArchivalItemDTO>> GetAllArchivalItems()
        {
            try
            {
                IEnumerable<ArchivalItemDTO> archivalItemDTOS =
                    _mapper.Map<IEnumerable<ArchivalItem>, IEnumerable<ArchivalItemDTO>>(_db.ArchivalItems);
                return archivalItemDTOS;

            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ArchivalItemDTO> GetArchivalItem(string archivalItemId)
        {
            try
            {
                ArchivalItemDTO archivalItem = _mapper.Map<ArchivalItem, ArchivalItemDTO>(
                await _db.ArchivalItems.FirstOrDefaultAsync(x => x.Id == archivalItemId));

                return archivalItem;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ArchivalItemDTO> IsArchivalItemUnique(string name)
        {
            try
            {
                ArchivalItemDTO archivalItem = _mapper.Map<ArchivalItem, ArchivalItemDTO>(
                await _db.ArchivalItems.FirstOrDefaultAsync(x => x.ArchivalItemName.ToLower() == name.ToLower()));

                return archivalItem;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ArchivalItemDTO> UpdateArchivalItem(string archivalItemId, ArchivalItemDTO archivalItemDTO)
        {
            try
            {
                if (archivalItemId == archivalItemDTO.Id)
                {
                    //valid
                    ArchivalItem archivalDetails = await _db.ArchivalItems.FindAsync(archivalItemId);
                    ArchivalItem archivalItem = _mapper.Map<ArchivalItemDTO, ArchivalItem>(archivalItemDTO, archivalDetails);
                    var updatedEmployee = _db.ArchivalItems.Update(archivalItem);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<ArchivalItem, ArchivalItemDTO>(updatedEmployee.Entity);
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
