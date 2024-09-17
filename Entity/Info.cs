using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity;

public class Info
{
    [Key]
    public Guid Id{get;set;}

    [ForeignKey(name:"PlaceId")]
    public Guid PlaceId{get;set;}

    public DateTime DateTimeInsert {get;set;}

    public string? Value{get;set;}

    public string? Type{get;set;}

    public virtual Place? Place{get;set;}
}
