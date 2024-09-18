using Contract;
using Contract.DTO;
using Contract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PlaceService : IPlace
    {
        public Task<PlaceResponse> AddAsync(PlaceAddRequest? placeAddRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid? Id)
        {
            throw new NotImplementedException();
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
