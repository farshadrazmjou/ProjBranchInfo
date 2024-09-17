using Entity;

namespace Contract.Enums;

public class InfoResponse
{
    public Guid Id{get;set;}

    public string? Value{get;set;}

    public InfoType Type{get;set;}

    public Guid PlaceId{get;set;}

    public Info ToInfo() =>
        new Info(){
            Id=Id,
            PlaceId=PlaceId,
            Type=Enum.GetName(Type),
            Value=Value
        };

    public InfoUpdateRequest ToInfoUpdateRequest() =>
        new InfoUpdateRequest(){
            Id=Id,
            PlaceId=PlaceId,
            Type=Type,
            Value=Value
        };
}

public static class InfoExtension
{
    public static InfoResponse ToInfoResponse(this Info info) =>
        new InfoResponse(){
            Id=info.Id,
            PlaceId=info.PlaceId,
            Type=Enum.Parse<InfoType>(info.Type??"")
        };
}