namespace DVLD.API.Config
{
    public class JwtConfig
    {
        public string  Secret { get; set; }
        public string? Issuer { get; set; }
        public string Auidiance { get; set; }
        public TimeSpan ExpireTime { get; set; }
    }
}
