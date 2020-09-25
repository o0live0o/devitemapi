/*
 * @Author: live0x 
 * @Date: 2020-09-25 09:56:19 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-25 10:19:22
 */
using System;

namespace devitemapi.Entity
{
    public class Stock : IEntity<int>
    {
        /// <summary>
        /// 流水号
        /// </summary>
        /// <value></value>
        public string SerialNo { get; set; }

        /// <summary>
        /// 仓库代码
        /// </summary>
        /// <value></value>
        public string StoreHouseCode { get; set; }

        /// <summary>
        /// 商品代码
        /// </summary>
        /// <value></value>
        public string GoodsCode { get; set; }

        /// <summary>
        /// 商品批次
        /// </summary>
        /// <value></value>
        public string Batch { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        /// <value></value>
        public decimal Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <value></value>
        public decimal Amount { get; set; }

        /// <summary>
        /// 商品重量
        /// </summary>
        /// <value></value>
        public decimal Weight { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        /// <value></value>
        public string Unit { get; set; }

        /// <summary>
        /// 每单位重量
        /// </summary>
        /// <value></value>
        public string UnitWeight { get; set; }

        /// <summary>
        /// 库存状态
        /// </summary>
        /// <value></value>
        public int State { get; set; }

        /// <summary>
        /// 入库日期
        /// </summary>
        /// <value></value>
        public DateTime StorageDate { get; set; }
    }
}