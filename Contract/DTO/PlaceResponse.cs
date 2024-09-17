using Entity;

namespace Contract.DTO;

public class PlaceResponse
{
    public Guid Id{get;set;}
    
    public string? Name{get;set;}

    public int Code{get;set;}

    public int Grade{get;set;}

    public string? Address{get;set;}

    public Place ToPlace() =>
        new Place(){
            Id=Id,
            Name=Name,
            Address=Address,
            Code=Code,
            Grade=Grade
        };

    public PlaceUpdateRequest ToPlaceUpdateRequest() =>
        new PlaceUpdateRequest(){
            Id=Id,
            Name=Name,
            Address=Address,
            Code=Code,
            Grade=Grade
        };
}

public static class PlaceExtension
{
    public static PlaceResponse ToPlaceResponse(this Place place) =>
        new PlaceResponse(){
            Id=place.Id,
            Address=place.Address,
            Code=place.Code,
            Grade=place.Grade,
            Name=place.Name
        };
}