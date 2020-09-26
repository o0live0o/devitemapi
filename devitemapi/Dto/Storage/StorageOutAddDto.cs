namespace devitemapi.Dto.Storage
{
    public class StorageOutAddDto
    {
        /// <summary>
        /// 入库单状态
        /// </summary>
        /// <value></value>
        public string State { get; set; }

        /// <summary>
        /// 出库类型
        /// </summary>
        /// <value></value>
        public string StorageOutype { get; set; }

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
        /// 商品入库数量
        /// </summary>
        /// <value></value>
        public decimal Amount { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        /// <value></value>
        public string Unit { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        /// <value></value>
        public decimal Weight { get; set; }

        /// <summary>
        /// 每单位重量
        /// </summary>
        /// <value></value>
        public decimal UnitWeight { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        /// <value></value>
        public string Batch { get; set; }
    }
}