using Contract.DTO;
using Entity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;

namespace Contract.Enums;

public class InfoResponse : IValidatableObject
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

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrEmpty(Value))
            yield return new ValidationResult(new ArgumentException(nameof(Value)).Message);
        if (PlaceId==Guid.Empty)
            yield return new ValidationResult(new ArgumentException(nameof(PlaceId)).Message);
    }

    public override bool Equals(object? obj)
    {
        InfoResponse? other = obj as InfoResponse;
        if (other == null)
            return false;
        return other.Value == Value && nameof(other.Type) == nameof(Type) && other.PlaceId == PlaceId && other.Id == Id;
    }

    public override int GetHashCode() =>
        base.GetHashCode();

    public override string ToString() =>
        $"Id : {Id} , Value : {Value} , Type : {nameof(Type)} , PlaceId : {PlaceId} ";
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