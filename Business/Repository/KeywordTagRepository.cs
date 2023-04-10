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
    public class KeywordTagRepository : IKeywordTagRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public KeywordTagRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<KeywordTagDTO> CreateKeywordTag(KeywordTagDTO keywordTagDTO)
        {
            KeywordTag keywordTag = _mapper.Map<KeywordTagDTO, KeywordTag>(keywordTagDTO);
            var addedkeywordTag = await _db.KeywordTags.AddAsync(keywordTag);
            await _db.SaveChangesAsync();
            return _mapper.Map<KeywordTag, KeywordTagDTO>(addedkeywordTag.Entity);
        }

        public async Task<string> DeleteKeywordTag(string keywordTagId)
        {
            var keywordTagDetails = await _db.KeywordTags.FindAsync(keywordTagId);
            if (keywordTagDetails != null)
            {
                _db.KeywordTags.Remove(keywordTagDetails);
                await _db.SaveChangesAsync();
                return "Done";
            }

            return "Done";

        }

        public async Task<IEnumerable<KeywordTagDTO>> GetAllKeywordTags()
        {
            try
            {
                IEnumerable<KeywordTagDTO> keywordTagDTOs =
                    _mapper.Map<IEnumerable<KeywordTag>, IEnumerable<KeywordTagDTO>>(_db.KeywordTags);
                return keywordTagDTOs;

            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<KeywordTagDTO> GetKeywordTag(string keywordTagID)
        {
            try
            {
                KeywordTagDTO archivalItem = _mapper.Map<KeywordTag, KeywordTagDTO>(
                await _db.KeywordTags.FirstOrDefaultAsync(x => x.keywordTagID == keywordTagID));

                return archivalItem;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<KeywordTagDTO> IsKeywordTagUnique(string name)
        {
            try
            {
                KeywordTagDTO keywordTagItem = _mapper.Map<KeywordTag, KeywordTagDTO>(
                await _db.KeywordTags.FirstOrDefaultAsync(x => x.keywordTagName.ToLower() == name.ToLower()));

                return keywordTagItem;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<KeywordTagDTO> UpdateKeywordTag(string keywordTagId, KeywordTagDTO keywordTagDTO)
        {
            try
            {
                if (keywordTagId == keywordTagDTO.keywordTagID)
                {
                    //valid
                    KeywordTag keywordTagDetails = await _db.KeywordTags.FindAsync(keywordTagId);
                    KeywordTag keywordTagItem = _mapper.Map<KeywordTagDTO, KeywordTag>(keywordTagDTO, keywordTagDetails);
                    var updatedEmployee = _db.KeywordTags.Update(keywordTagItem);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<KeywordTag, KeywordTagDTO>(updatedEmployee.Entity);
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
