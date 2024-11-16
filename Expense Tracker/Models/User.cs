using System.ComponentModel.DataAnnotations;
namespace Expense_Tracker.Models;
public class User
{
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
    