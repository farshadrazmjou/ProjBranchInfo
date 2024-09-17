using Entity;

namespace Contract.DTO;

public class PlaceAddRequest
{
    public string? Name{get;set;}

    public int Code{get;set;}

    public int Grade{get;set;}

    public string? Address{get;set;}

    public Place ToPlace() =>
        new Place(){
            Id=Guid.NewGuid(),
            Address=Address,
            Code=Code,
            DateTimeInsert=DateTime.Now,
            Grade=Grade,
            Name=Name
        };
    
}