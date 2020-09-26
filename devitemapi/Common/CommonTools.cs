using System;
using devitemapi.Enum;

namespace devitemapi.Common
{
    public abstract class CommonTools
    {
        public static string CreateOrderNo(SerialNoEnum serialNoEnum) =>
        serialNoEnum switch
        {
            SerialNoEnum.StorageIn => CreateStorageOrderNo("IN"),
            SerialNoEnum.StorageOut => CreateStorageOrderNo("Out"),
            _ => throw new ArgumentException(message: "invalid enum value")
        };


        private static string CreateStorageOrderNo(string key)
        {
            return DateTime.Now.ToString($"yyyyMMdd{key}HHmmssfff");
        }
    }


}