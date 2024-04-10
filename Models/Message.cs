using System.ComponentModel.DataAnnotations;

namespace ASPNetCore_pr4.Models;

public class Message
{
    [Key]
    public int id{ get; set; }

    public int from_user_id { get; set; }
    public int to_user_id { get; set; }
    public string? title { get; set; }
    public string? body { get; set; }
    public DateTime send_date { get; set; }
    public string? status { get; set; }
}
