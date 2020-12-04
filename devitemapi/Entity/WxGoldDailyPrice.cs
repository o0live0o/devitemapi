/*
 * @Author: live0x 
 * @Date: 2020-10-28 10:39:50 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-10-28 10:39:50 
 */
using System;

namespace devitemapi.Entity
{
    public class WxGoldDailyPrice :IEntity<int>
    {
        public string ConsignmentId { get; set; }
        public string ZoneId { get; set; }
        public string ZoneName { get; set; }
        public string ServerId { get; set; }
        public string ServerName { get; set; }
        public string SellerRoleName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal GoldAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public string Remark { get; set; }
        public DateTime GainTime { get; set; }
    }
}