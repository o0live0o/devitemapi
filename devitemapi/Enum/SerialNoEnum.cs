
using System.ComponentModel;

namespace devitemapi.Enum
{
    public enum SerialNoEnum
    {
        [Description("入库单")]
        StorageIn = 1,
        [Description("出库单")]
        StorageOut = 2
    }
}