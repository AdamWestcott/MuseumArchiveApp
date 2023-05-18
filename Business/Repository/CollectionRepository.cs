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
    public class CollectionRepository:ICollectionRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public CollectionRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CollectionDTO> CreateCollection(CollectionDTO collectionDTO)
        {
            Collection collection = _mapper.Map<CollectionDTO, Collection>(collectionDTO);
            var addedcollection = await _db.Collections.AddAsync(collection);
            await _db.SaveChangesAsync();
            return _mapper.Map<Collection, CollectionDTO>(addedcollection.Entity);
        }

        public async Task<string> DeleteCollection(string collectionId)
        {
            var collectionDetails = await _db.Collections.FindAsync(collectionId);
            if (collectionDetails != null)
            {
                _db.Collections.Remove(collectionDetails);
                await _db.SaveChangesAsync();
                return "Done";
            }

            return "Done";

        }

        public async Task<IEnumerable<CollectionDTO>> GetAllCollections()
        {
            try
            {
                IEnumerable<CollectionDTO> collectionDTOs =
                    _mapper.Map<IEnumerable<Collection>, IEnumerable<CollectionDTO>>(_db.Collections);
                return collectionDTOs;

            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CollectionDTO> GetCollection(string collectionID)
        {
            try
            {
                CollectionDTO archivalItem = _mapper.Map<Collection, CollectionDTO>(
                await _db.Collections.FirstOrDefaultAsync(x => x.CollectionName == collectionID));

                return archivalItem;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CollectionDTO> IsCollectionUnique(string name)
        {
            try
            {
                CollectionDTO collectionItem = _mapper.Map<Collection, CollectionDTO>(
                await _db.Collections.FirstOrDefaultAsync(x => x.CollectionName.ToLower() == name.ToLower()));

                return collectionItem;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CollectionDTO> UpdateCollection(string collectionId, CollectionDTO collectionDTO)
        {
            try
            {
                if (collectionId == collectionDTO.CollectionName)
                {
                    //valid
                    Collection collectionDetails = await _db.Collections.FindAsync(collectionId);
                    Collection collectionItem = _mapper.Map<CollectionDTO, Collection>(collectionDTO, collectionDetails);
                    var updatedEmployee = _db.Collections.Update(collectionItem);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Collection, CollectionDTO>(updatedEmployee.Entity);
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
