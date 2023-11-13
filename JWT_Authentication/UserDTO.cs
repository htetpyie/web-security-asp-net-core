namespace JWT_Authentication
{
    public class UserDTO
    {
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }

    public class User
    {
        public string Username { get; set; } = String.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
