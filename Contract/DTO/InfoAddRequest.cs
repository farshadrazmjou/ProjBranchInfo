using System.Reflection.Metadata.Ecma335;
using Contract.Enums;
using Entity;

namespace Contract.DTO;

public class InfoAddRequest
{
    public string? Value{get;set;}

    public InfoType Type{get;set;}

    public Guid PlaceId{get;set;}

    public Info ToInfo() =>
        new Info(){
            Id=Guid.NewGuid(),
            DateTimeInsert=DateTime.Now,
            PlaceId=PlaceId,
            Type=Enum.GetName<InfoType>(Type),
            Value=Value
        };
}