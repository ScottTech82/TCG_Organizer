using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TCG_Organizer.Models;

[Index("Username", IsUnique = true, Name = "UIDX_Username")]
public class User
{
    public int Id { get; set; }

    [StringLength(30)]
    public string? Name { get; set; }

    [StringLength(30)]
    public string Username { get; set; }

    [StringLength(30)]
    public string Password { get; set; }

    [StringLength(125)]
    public string? Email { get; set; }

    public int TotalCards { get; set; } = 0;  

    public bool IsAdmin { get; set; }




}
