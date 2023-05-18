using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ICollectionRepository
    {
        public Task<CollectionDTO> CreateCollection(CollectionDTO collectionDTO);
        public Task<CollectionDTO> UpdateCollection(string collectionId, CollectionDTO collectionDTO);
        public Task<CollectionDTO> GetCollection(string collectionId);
        public Task<string> DeleteCollection(string collectionId);
        public Task<IEnumerable<CollectionDTO>> GetAllCollections();
        public Task<CollectionDTO> IsCollectionUnique(string collectionName);
    }
}
