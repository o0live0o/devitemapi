### 表结构
Storage
仓库|产品|批次|价格|库存|单位|状态
-|-|-|-|-|-|-
ID *StorehouseCode *GoodsCode *Batch Price Amount Weight UnitWeight Unit State *StorageDate ModifyDate StorageUser StorageUserId ModifyUser ModifyUserId




StorageHistory
仓库|产品|批次|数量|单位
-|-|-|-|-
### 功能
- 库存
    - 库存余量
    - 库存转移
    - 库存冻结

- 入库
    - 正常入库
    - 退货入库
    - 取消入库
  ```
  batch -> storage
  record storage history
  ```
- 出库
    - 正常出库
    - 赠品出库
    - 取消出库
  ```
  storage -> out 
  record storage history
  ```
- 盘点



