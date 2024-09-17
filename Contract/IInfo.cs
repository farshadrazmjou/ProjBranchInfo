using Contract.DTO;
using Contract.Enums;

namespace Contract;

public interface IInfo
{
    Task<InfoResponse> AddAsync(InfoAddRequest? infoAddRequest);

    Task<InfoResponse> GetByIdAsync(Guid? Id);

    Task<List<InfoResponse>> GetAllAsync();

    Task<bool> DeleteAsync(Guid? Id);

    Task<InfoResponse> UpdateAsync(InfoUpdateRequest? InfoUpdateRequest);

    Task<List<InfoResponse>> SearchAsync(string searchField,string? searchValue);

    Task<List<InfoResponse>> SortAsync(List<InfoResponse> infos,string sortField,SortOrder sortOrder);
}