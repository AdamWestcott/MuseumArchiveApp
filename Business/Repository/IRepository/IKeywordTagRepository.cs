using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IKeywordTagRepository
    {
        public Task<KeywordTagDTO> CreateKeywordTag(KeywordTagDTO keywordTagDTO);
        public Task<KeywordTagDTO> UpdateKeywordTag(string keywordTagId, KeywordTagDTO keywordTagDTO);
        public Task<KeywordTagDTO> GetKeywordTag(string keywordTagId);
        public Task<string> DeleteKeywordTag(string keywordTagId);
        public Task<IEnumerable<KeywordTagDTO>> GetAllKeywordTags();
        public Task<KeywordTagDTO> IsKeywordTagUnique(string KeyWordTagName);
    }
}
