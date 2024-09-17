namespace Contract.DTO;

public class PlaceUpdateRequest
{
    public Guid Id{get;set;}
    
    public string? Name{get;set;}

    public int Code{get;set;}

    public int Grade{get;set;}

    public string? Address{get;set;}
}