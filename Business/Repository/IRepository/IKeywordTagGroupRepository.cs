using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IKeywordTagGroupRepository
    {
        public Task<KeywordTagGroupDTO> CreateKeywordTagGroup(KeywordTagGroupDTO keywordTagGroupDTO);
        public Task<KeywordTagGroupDTO> UpdateKeywordTagGroup(string keywordTagGroupId, KeywordTagGroupDTO keywordTagGroupDTO);
        public Task<KeywordTagGroupDTO> GetKeywordTagGroup(string keywordTagGroupId);
        public Task<string> DeleteKeywordTagGroup(string keywordTagGroupId);
        public Task<IEnumerable<KeywordTagGroupDTO>> GetAllKeywordTagGroups();
        public Task<IEnumerable<KeywordTagGroupDTO>> GetAllKeywordTagGroupsByArchivalItemID(string archivalId);
        public Task<IEnumerable<KeywordTagGroupDTO>> GetAllKeywordTagGroupsByKeywordName(string keywordName);
        public Task<KeywordTagGroupDTO> DoesKeywordTagGroupExist(string keywordTagGroupName, string archivalItemID);
    }
}
