using System.ComponentModel.DataAnnotations;

namespace Entity;

public class Place
{
    [Key]
    public Guid Id{get;set;}
    
    public DateTime DateTimeInsert{get;set;}

    public string? Name{get;set;}

    public int Code{get;set;}

    public int Grade{get;set;}

    public string? Address{get;set;}

    public virtual ICollection<Info>? Infos {get;set;}
}