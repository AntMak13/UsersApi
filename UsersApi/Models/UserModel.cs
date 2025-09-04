namespace UsersApi.Models;

// По заданию "Сущность User"

public class UserModel
{
    public int Guid { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int Gender { get; set; } // 0 - female, 1 - male, 2 - noInfo
    public DateTime? Birthday { get; set; }
    public bool Admin { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime RevokedOn { get; set; }
    public string RevokedBy { get; set; }
}