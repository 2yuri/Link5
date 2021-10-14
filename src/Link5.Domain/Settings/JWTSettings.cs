using System;
namespace Link5.Domain.Settings
{
    public class JWTSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public double DurationInMinutes { get; set; }
    }
}
