using Contract;
using Contract.DTO;
using Contract.Enums;
using Entity;

namespace Service
{
    public class InfoService : IInfo
    {
        PlaceInfoDbContext _db;

        public InfoService(PlaceInfoDbContext dbContext)
        {
            _db=dbContext;
        }

        public Task<InfoResponse> AddAsync(InfoAddRequest? infoAddRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid? Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InfoResponse>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<InfoResponse> GetByIdAsync(Guid? Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InfoResponse>> SearchAsync(string searchField, string? searchValue)
        {
            throw new NotImplementedException();
        }

        public Task<List<InfoResponse>> SortAsync(List<InfoResponse> infos, string sortField, SortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        public Task<InfoResponse> UpdateAsync(InfoUpdateRequest? InfoUpdateRequest)
        {
            throw new NotImplementedException();
        }
    }
}
