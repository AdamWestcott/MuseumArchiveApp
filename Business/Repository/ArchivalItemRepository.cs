using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using Business.Repository.IRepository;

namespace Business.Repository
{
    public class ArchivalItemRepository : IArchivalItemRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ArchivalItemRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ArchivalItemDTO> CreateArchivalItem(ArchivalItemDTO archivalItemDTO)
        {
            ArchivalItem archivalItem = _mapper.Map<ArchivalItemDTO, ArchivalItem>(archivalItemDTO);
            var addedArchivalItem = await _db.ArchivalItems.AddAsync(archivalItem);
            await _db.SaveChangesAsync();
            return _mapper.Map<ArchivalItem, ArchivalItemDTO>(addedArchivalItem.Entity);
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
