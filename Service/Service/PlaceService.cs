using Contract;
using Contract.DTO;
using Contract.Enums;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PlaceService : IPlace
    {

        PlaceInfoDbContext _db;

        public PlaceService(PlaceInfoDbContext dbContext)
        {
            _db=dbContext;
        }

        public async Task<PlaceResponse> AddAsync(PlaceAddRequest? placeAddRequest)
        {
            
            if(placeAddRequest==null)
                throw new ArgumentNullException();

            Place place_for_add=placeAddRequest.ToPlace();
            await _db.Places.AddAsync(place_for_add);
            int count=await _db.SaveChangesAsync();
            if(count==0)
                throw new Exception("Place was not add");

            return place_for_add.ToPlaceResponse();
        }

        public async Task<bool> DeleteAsync(Guid? Id)
        {
            if(Id==null)
                throw new ArgumentNullException();
            Place? place_for_delete=await _db.Places.Where(p => p.Id==Id).FirstOrDefaultAsync();
            if(place_for_delete==null)
                throw new InvalidDataException();
            
            _db.Places.Remove(place_for_delete);
            int count=await _db.SaveChangesAsync();
            if(count>1)
                return true;
            return false;
        }

        public Task<List<PlaceResponse>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PlaceResponse> GetByIdAsync(Guid? Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PlaceResponse>> SearchAsync(string searchField, string? searchValue)
        {
            throw new NotImplementedException();
        }

        public Task<List<PlaceResponse>> SortAsync(List<PlaceResponse> places, string sortField, SortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        public Task<PlaceResponse> UpdateAsync(PlaceUpdateRequest? placeUpdateRequest)
        {
            throw new NotImplementedException();
        }
    }
}
