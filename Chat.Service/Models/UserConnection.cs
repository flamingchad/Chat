using System.ComponentModel.DataAnnotations;

namespace Chat.Service.Models;

public class UserConnection
{
    public int Id { get; set; }
    [MaxLength(200)]
    public string userName { get; set; } = String.Empty;
    [MaxLength(200)]
    public string chatRoom { get; set; } = String.Empty;
}