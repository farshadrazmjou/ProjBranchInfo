using System.Data;
using Contract.DTO;
using Contract.Enums;
using Microsoft.VisualBasic.FileIO;

namespace Contract;

public interface IPlace
{
    
    Task<PlaceResponse> AddAsync(PlaceAddRequest? placeAddRequest);

    Task<PlaceResponse> GetByIdAsync(Guid? Id);

    Task<List<PlaceResponse>> GetAllAsync();

    Task<bool> DeleteAsync(Guid? Id);

    Task<PlaceResponse> UpdateAsync(PlaceUpdateRequest? placeUpdateRequest);

    Task<List<PlaceResponse>> SearchAsync(string searchField,string? searchValue);

    Task<List<PlaceResponse>> SortAsync(List<PlaceResponse> places,string sortField,SortOrder sortOrder);
}
