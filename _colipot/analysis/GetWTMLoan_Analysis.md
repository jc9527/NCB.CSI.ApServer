# 2025信貸匯入分析

## 功能概述

信貸斷點名單 
信貸諮詢名單

此功能透過 SFTP 連線下載檔案，解析 Tab 分隔格式的資料，並將資料匯入到行銷活動任務系統中。

## 檔案格式規範

### 基本規格

- **檔案格式**：純文字檔案（.txt）
- **分隔符號**：Tab (\t)
- **欄位總數**：41 個欄位
- **編碼格式**：UTF-8
- **檔名模式**：`wtm_{yyyyMMdd}.txt`（例如：wtm_20240109.txt）

## 資料表結構 - CampaignTasks

### 資料表基本資訊

- **資料表名稱**：CampaignTasks
- **用途**：儲存行銷活動任務資料
- **Model 類別**：NCB.CSI.Models.CSI.CampaignTasksRq

### 資料表欄位分類

#### 1. 系統欄位

| 欄位名稱        | 資料類型 | 說明           |
| --------------- | -------- | -------------- |
| TaskId          | long     | 任務唯一識別碼 |
| CreatedAt       | DateTime | 建立時間       |
| CreatedBy       | string   | 建立者         |
| ModifiedAt      | DateTime | 修改時間       |
| ModifiedBy      | string   | 修改者         |
| LastContactDate | DateTime | 最後聯絡日期   |
| ResultCode      | string   | 結果代碼       |
| Note            | string   | 備註           |

#### 2. 活動相關欄位

| 欄位名稱       | 資料類型 | 說明                 | 資料來源    |
| -------------- | -------- | -------------------- | ----------- |
| CampaignCode   | string   | 活動代碼             | 檔案欄位[2] |
| WaveCode       | string   | 波次代碼             | 命令參數    |
| DepartmentCode | string   | 部門代碼             | 命令參數    |
| TaskTag1       | string   | 任務標籤（案件編號） | 檔案欄位[1] |

#### 3. 客戶基本資料欄位

| 欄位名稱              | 資料類型  | 說明               | 資料來源     |
| --------------------- | --------- | ------------------ | ------------ |
| CustId                | string    | 身分證字號         | 檔案欄位[16] |
| ChineseName           | string    | 中文姓名           | 檔案欄位[14] |
| Gender                | int       | 性別（1:男, 2:女） | 檔案欄位[17] |
| DOB                   | DateTime? | 出生日期           | 檔案欄位[18] |
| MobileNo              | string    | 手機號碼           | 檔案欄位[19] |
| CorrespondenceTelNo   | string    | 聯絡電話           | 檔案欄位[20] |
| Email1                | string    | 電子郵件           | 檔案欄位[21] |
| CorrespondenceAddress | string    | 通訊地址           | 檔案欄位[22] |

#### 4. 整數型態欄位（Int01-Int20）

| 欄位名稱    | 資料類型 | 對應檔案欄位 | 說明                     |
| ----------- | -------- | ------------ | ------------------------ |
| Int01       | int      | 欄位[0]      | 序號                     |
| Int02       | int      | 欄位[11]     | 繳費期數                 |
| Int03       | int      | 欄位[13]     | 年繳保費（轉換為整數）   |
| Int04       | int      | 欄位[30]     | 優先順序                 |
| Int05       | int      | 欄位[32]     | 累計保費                 |
| Int18       | int      | 欄位[18]     | 出生年（從出生日期擷取） |
| Int19       | int      | 欄位[18]     | 出生月（從出生日期擷取） |
| Int20       | int      | 欄位[18]     | 出生日（從出生日期擷取） |
| Int06-Int17 | int      | -            | 保留欄位（未使用）       |

#### 5. 字串型態欄位（Data01-Data30）

| 欄位名稱      | 資料類型 | 對應檔案欄位 | 說明                            |
| ------------- | -------- | ------------ | ------------------------------- |
| Data01        | string   | 欄位[15]     | 英文姓名                        |
| Data02        | string   | 欄位[36]     | 備註1                           |
| Data03        | string   | 欄位[37]     | 備註2                           |
| Data04        | string   | 欄位[38]     | 備註3                           |
| Data05        | string   | 欄位[39]     | 備註4                           |
| Data06        | string   | 欄位[27]     | 前次聯絡日期                    |
| Data07        | string   | 欄位[5]      | 保險方案                        |
| Data08        | string   | 欄位[4]      | 保險公司                        |
| Data09        | string   | 欄位[6]      | 保險期間                        |
| Data10        | string   | 欄位[7]      | 保險金額                        |
| Data11        | string   | 欄位[8]      | 投保日期（格式化為 yyyy/MM/dd） |
| Data12        | string   | 欄位[9]      | 到期日期（格式化為 yyyy/MM/dd） |
| Data13        | string   | 欄位[10]     | 繳費方式                        |
| Data14        | string   | 欄位[12]     | 保費金額                        |
| Data15        | string   | 欄位[24]     | 業務員代碼                      |
| Data16        | string   | 欄位[25]     | 業務員姓名                      |
| Data17        | string   | 欄位[26]     | 通路代碼                        |
| Data18        | string   | 欄位[28]     | 聯絡結果                        |
| Data19        | string   | 欄位[29]     | 聯絡備註                        |
| Data20        | string   | 欄位[31]     | 客戶等級                        |
| Data21        | string   | 欄位[33]     | 理賠記錄                        |
| Data22        | string   | 欄位[34]     | 客戶來源                        |
| Data23        | string   | 欄位[35]     | 推薦人                          |
| Data24        | string   | 欄位[23]     | 職業類別                        |
| Data25        | string   | 欄位[1]      | 案件編號                        |
| Data26        | string   | 欄位[3]      | 產品類型                        |
| Data30        | string   | 欄位[40]     | 電訪截止日期                    |
| Data27-Data29 | string   | -            | 保留欄位（未使用）              |

#### 6. 特殊欄位

| 欄位名稱 | 資料類型 | 說明                                             |
| -------- | -------- | ------------------------------------------------ |
| JsonData | string   | 原始資料的 JSON 字串（保存完整的 41 個欄位陣列） |

## 欄位對應表

| 欄位索引 | 欄位名稱     | 資料類型 | 說明                      | 對應系統欄位                         |
| -------- | ------------ | -------- | ------------------------- | ------------------------------------ |
| 0        | 序號         | Integer  | 資料序號                  | Int01                                |
| 1        | 案件編號     | String   | 唯一識別碼                | Data25, TaskTag1                     |
| 2        | 活動代碼     | String   | 行銷活動代碼              | CampaignCode                         |
| 3        | 產品類型     | String   | 保險產品類型              | Data26                               |
| 4        | 保險公司     | String   | 承保公司名稱              | Data08                               |
| 5        | 保險方案     | String   | 保險方案名稱              | Data07                               |
| 6        | 保險期間     | String   | 保險期間說明              | Data09                               |
| 7        | 保險金額     | String   | 保險金額                  | Data10                               |
| 8        | 投保日期     | Date     | 投保生效日期 (yyyy/MM/dd) | Data11                               |
| 9        | 到期日期     | Date     | 保險到期日期 (yyyy/MM/dd) | Data12                               |
| 10       | 繳費方式     | String   | 繳費週期（月繳/年繳等）   | Data13                               |
| 11       | 繳費期數     | Integer  | 總繳費期數                | Int02                                |
| 12       | 保費金額     | String   | 每期保費金額              | Data14                               |
| 13       | 年繳保費     | Double   | 年繳保費總額              | Int03                                |
| 14       | 客戶姓名     | String   | 被保險人姓名              | ChineseName                          |
| 15       | 英文姓名     | String   | 被保險人英文姓名          | Data01                               |
| 16       | 身分證字號   | String   | 身分證字號/統一編號       | CustId                               |
| 17       | 性別         | Integer  | 性別（1:男, 2:女）        | Gender                               |
| 18       | 出生日期     | Date     | 出生日期 (yyyy/MM/dd)     | DOB, Int18(年), Int19(月), Int20(日) |
| 19       | 手機號碼     | String   | 主要聯絡手機              | MobileNo                             |
| 20       | 聯絡電話     | String   | 其他聯絡電話              | CorrespondenceTelNo                  |
| 21       | 電子郵件     | String   | Email 地址                | Email1                               |
| 22       | 通訊地址     | String   | 完整通訊地址              | CorrespondenceAddress                |
| 23       | 職業類別     | String   | 職業風險類別              | Data24                               |
| 24       | 業務員代碼   | String   | 招攬業務員代碼            | Data15                               |
| 25       | 業務員姓名   | String   | 招攬業務員姓名            | Data16                               |
| 26       | 通路代碼     | String   | 銷售通路代碼              | Data17                               |
| 27       | 前次聯絡日期 | String   | 最近一次聯絡日期          | Data06                               |
| 28       | 聯絡結果     | String   | 前次聯絡結果代碼          | Data18                               |
| 29       | 聯絡備註     | String   | 聯絡記錄備註              | Data19                               |
| 30       | 優先順序     | Integer  | 電訪優先順序              | Int04                                |
| 31       | 客戶等級     | String   | 客戶價值等級              | Data20                               |
| 32       | 累計保費     | Integer  | 歷史累計保費              | Int05                                |
| 33       | 理賠記錄     | String   | 理賠次數或金額            | Data21                               |
| 34       | 客戶來源     | String   | 客戶來源管道              | Data22                               |
| 35       | 推薦人       | String   | 推薦人資訊                | Data23                               |
| 36       | 備註1        | String   | 自訂欄位1                 | Data02                               |
| 37       | 備註2        | String   | 自訂欄位2                 | Data03                               |
| 38       | 備註3        | String   | 自訂欄位3                 | Data04                               |
| 39       | 備註4        | String   | 自訂欄位4                 | Data05                               |
| 40       | 電訪截止日期 | String   | 電訪任務截止日期          | Data30                               |

## 資料處理邏輯

### 1. 檔案讀取

- 透過 SFTP 連線到指定主機
- 根據日期參數計算目標檔案名稱
- 下載檔案到記憶體進行處理

### 2. 資料解析

- 移除雙引號和換行符號
- 使用 Tab 字元分割每一行
- 驗證欄位數量是否為 41 個

### 3. 資料轉換

- 日期欄位：轉換為 yyyy/MM/dd 格式
- 數值欄位：處理空值並轉換為相應數值型態
- 出生日期：額外拆分為年、月、日三個欄位儲存

### 4. 資料匯入

- 將解析後的資料封裝為 CampaignTasksRq 物件
- 呼叫 ImportCampaignTasks 服務進行資料儲存
- 記錄每筆資料的處理結果

## 執行命令範例

```bash
NCB.CSI.Batch.exe GetWTMInsuranceCases \
  --host TsaiHomeCloud.synology.me \
  --username Devpro \
  --password [密碼] \
  --filepath /oli_ftc/download/wtm/ \
  --prefix wtm_ \
  --extension .txt \
  --datediff 0 \
  --fieldCount 41 \
  --wave WAVE_{{TODAY_WAVE}} \
  --wavedays 30
  --department H0504
```

### 參數說明

- `host`：SFTP 伺服器位址
- `username`：SFTP 登入帳號
- `password`：SFTP 登入密碼
- `filepath`：檔案所在的遠端路徑
- `prefix`：檔案名稱前綴
- `extension`：檔案副檔名
- `datediff`：日期偏移量（0 表示今天，-1 表示昨天）
- `fieldCount`：預期的欄位數量（必須為 41）
- `wave`：活動波次代碼
- `department`：部門代碼

## 注意事項

1. **檔案格式驗證**

   - 系統會嚴格檢查欄位數量，不符合 41 個欄位的資料列將被跳過
   - 空白行會自動忽略
2. **資料型態轉換**

   - 日期欄位若為空值將設為 null
   - 數值欄位若為空值將設為 0
   - 所有文字欄位會保留原始內容
3. **錯誤處理**

   - 檔案不存在時會記錄錯誤並返回空資料
   - 每筆資料的處理結果都會記錄在日誌中
   - 原始資料會完整保存在 JsonData 欄位中供追蹤
4. **效能考量**

   - 檔案在記憶體中處理，適合中小型檔案
   - 大型檔案可能需要考慮分批處理機制

## 自動新增波段

## 
    sp_CreateCampaignWave
