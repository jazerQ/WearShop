namespace WearShop.Models.Account;

public class RegisterUserRequest
{
    public string Username { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
}