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
    public class KeywordTagGroupRepository : IKeywordTagGroupRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public KeywordTagGroupRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<KeywordTagGroupDTO> CreateKeywordTagGroup(KeywordTagGroupDTO keywordTagGroupDTO)
        {
            KeywordTagGroup keywordTagGroup = _mapper.Map<KeywordTagGroupDTO, KeywordTagGroup>(keywordTagGroupDTO);
            var addedkeywordTagGroup = await _db.KeywordTagGroups.AddAsync(keywordTagGroup);
            await _db.SaveChangesAsync();
            return _mapper.Map<KeywordTagGroup, KeywordTagGroupDTO>(addedkeywordTagGroup.Entity);
        }

        public async Task<string> DeleteKeywordTagGroup(string keywordTagGroupId)
        {
            var keywordTagGroupDetails = await _db.KeywordTagGroups.FindAsync(keywordTagGroupId);
            if (keywordTagGroupDetails != null)
            {
                _db.KeywordTagGroups.Remove(keywordTagGroupDetails);
                await _db.SaveChangesAsync();
                return "Done";
            }

            return "Done";

        }

        public async Task<IEnumerable<KeywordTagGroupDTO>> GetAllKeywordTagGroups()
        {
            try
            {
                IEnumerable<KeywordTagGroupDTO> keywordTagDTOs =
                    _mapper.Map<IEnumerable<KeywordTagGroup>, IEnumerable<KeywordTagGroupDTO>>(_db.KeywordTagGroups);
                return keywordTagDTOs;

            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<KeywordTagGroupDTO> GetKeywordTagGroup(string keywordTagGroupId)
        {
            try
            {
                KeywordTagGroupDTO keywordTagGroup = _mapper.Map<KeywordTagGroup, KeywordTagGroupDTO>(
                await _db.KeywordTagGroups.FirstOrDefaultAsync(x => x.keywordTagGroupID == keywordTagGroupId));

                return keywordTagGroup;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IEnumerable<KeywordTagGroupDTO>> GetAllKeywordTagGroupsByArchivalItemID(string archivalItemID)
        {
            List<KeywordTagGroupDTO> result = new List<KeywordTagGroupDTO>();
            List<KeywordTagGroup> providences = _db.KeywordTagGroups.Where(x => x.ArchivalItemID == archivalItemID).ToList();
            result = _mapper.Map<List<KeywordTagGroupDTO>>(providences);
            return await Task.FromResult(result);
        }

        public async Task<IEnumerable<KeywordTagGroupDTO>> GetAllKeywordTagGroupsByKeywordName(string keywordName)
        {
            List<KeywordTagGroupDTO> result = new List<KeywordTagGroupDTO>();
            List<KeywordTagGroup> providences = _db.KeywordTagGroups.Where(x => x.keywordTagName == keywordName).ToList();
            result = _mapper.Map<List<KeywordTagGroupDTO>>(providences);
            return await Task.FromResult(result);
        }

        public async Task<KeywordTagGroupDTO> DoesKeywordTagGroupExist(string name, string archivalID)
        {
            try
            {
                KeywordTagGroupDTO keywordTagGroupItem = _mapper.Map<KeywordTagGroup, KeywordTagGroupDTO>(
                await _db.KeywordTagGroups.FirstOrDefaultAsync(x => x.keywordTagName.ToLower() == name.ToLower() && x.ArchivalItemID == archivalID));

                return keywordTagGroupItem;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<KeywordTagGroupDTO> UpdateKeywordTagGroup(string keywordTagGroupId, KeywordTagGroupDTO keywordTagGroupDTO)
        {
            try
            {
                if (keywordTagGroupId == keywordTagGroupDTO.keywordTagGroupID)
                {
                    //valid
                    KeywordTagGroup keywordTagDetails = await _db.KeywordTagGroups.FindAsync(keywordTagGroupId);
                    KeywordTagGroup keywordTagItem = _mapper.Map<KeywordTagGroupDTO, KeywordTagGroup>(keywordTagGroupDTO, keywordTagDetails);
                    var updatedEmployee = _db.KeywordTagGroups.Update(keywordTagItem);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<KeywordTagGroup, KeywordTagGroupDTO>(updatedEmployee.Entity);
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
