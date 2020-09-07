namespace devitemapi.Common
{
    public class AppConfig
    {
        public static ConfigEntity Config { get; set; }
    }

    public class ConfigEntity
    {
        public string JwtSecurityKey { get; set; }

        public string Audience { get; set; }

        public string Issuer { get; set; }

        /// <summary>
        /// 过期时间(min)
        /// </summary>
        public int Expire { get; set; }
    }
}