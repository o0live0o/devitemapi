using System;

namespace devitemapi.Infrastructure
{
    public class Snowflake
    {
        private long _timestamp = -1L;

        private long _lastTimestamp = -1L;

        private long _sequence { get; set; }

        private static int _sequenceBits = 12;
        private long _sequenceMask = -1L ^ (-1L << _sequenceBits);

        public long NextId()
        {
            var timestamp = GetTimestamp();
            if (timestamp == _lastTimestamp)
            {
                _sequence = (_sequence + 1) & _sequenceMask;
                if(_sequence == 0)
                {
                    timestamp = NextTimestamp(_lastTimestamp);
                }
            }
            else
            {
                _sequence = 0;
            }
            _lastTimestamp = timestamp;
            // 先将当前时间戳左移，放到41 bit那儿；将机房id左移放到5 bit那儿；将机器id左移放到5 bit那儿；将序号放最后12 bit
            // 最后拼接起来成一个64 bit的二进制数字，转换成10进制就是个long型
            // ((timestamp - INITIAL_TIME_STAMP) << TIMESTAMP_OFFSET)| (datacenterId << DATACENTERID_OFFSET)| (workerId << WORKERID_OFFSET)| sequence

            //((timestamp-twepoch) << timestampLeftShift)|(datacenterId << datacenterIdShift)|(workerId << workerIdShift) | sequence;
            return 0;
        }

        private long NextTimestamp(long lastTimestamp)
        {
            var timestamp = GetTimestamp();
            while (timestamp <= lastTimestamp)
            {
                timestamp = GetTimestamp();
            }
            return timestamp;
        }

        private long GetTimestamp()
        {
            return (long)(DateTime.Now - (new DateTime(1970, 1, 1, 0, 0, 0))).TotalMilliseconds;
        }
    }
}