using System.ComponentModel.DataAnnotations;

namespace ASPNetCore_pr4.Models;

public class Users
{
    [Key]
    public int id{ get; set; }
    
    public string? login{ get; set; }
    public string? password { get; set; }
    public string? surname { get; set; }
    public string? name { get; set; }
    public string? patronymic { get; set; }
}
