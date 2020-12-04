using System;

namespace devitemapi.Entity
{
    public class WxAction : BaseEntity<int>
    {
        public string ActionName { get; set; }

        public string ActionCode { get; set; }
    }
}