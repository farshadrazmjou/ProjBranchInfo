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

    public override bool Equals(object? obj)
    {
        PlaceResponse? other = obj as PlaceResponse;
        if (other == null) 
            return false;
        return other.Name==Name && other.Code==Code && other.Grade==Grade && other.Address==Address && other.Id==Id;
    }

    public override int GetHashCode() =>
        base.GetHashCode();
    

    public override string ToString() =>
        $"Id : {Id} , Name : {Name} , Code : {Code} , Grade : {Grade} , Address : {Address}";
 
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