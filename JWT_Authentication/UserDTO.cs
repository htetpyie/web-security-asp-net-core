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

        public string RefreshToken { get;set; } = String.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
    }

    public class RefreshToken
    {
        public string Token { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expires { get; set; } = DateTime.Now;


    }
}
