namespace Contract.Enums;

public class InfoUpdateRequest
{
    public Guid Id{get;set;}

    public string? Value{get;set;}

    public InfoType Type{get;set;}

    public Guid? PlaceId{get;set;}
}