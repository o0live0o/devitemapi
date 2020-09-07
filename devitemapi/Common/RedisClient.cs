using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;

namespace devitemapi.Common
{
    public class RedisClient
    {
        private static readonly object Locker = new object();

        private ConnectionMultiplexer _connectionMultiplexer;

        private static RedisClient _redisClient;

        private IDatabase db = null;

        private RedisClient()
        {
        }

        public static RedisClient GetRedisClient
        {
            get
            {
                if (_redisClient == null)
                {
                    lock (Locker)
                    {
                        if (_redisClient == null)
                        {
                            _redisClient = new RedisClient();
                        }
                    }
                }
                return _redisClient;
            }
        }

        public void Init(IConfiguration configuration)
        {
            try
            {
                var conStr = configuration.GetConnectionString("RedisStr");
                _connectionMultiplexer = ConnectionMultiplexer.Connect(conStr);
                db = _connectionMultiplexer.GetDatabase();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SetString(string key, string val, TimeSpan? expire = default(TimeSpan?))
        {
            return db.StringSet(key, val, expire);
        }

        public string GetString(string key)
        {
            return db.StringGet(key);
        }
    }
}