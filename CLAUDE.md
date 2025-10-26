# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## 專案概覽

這是 NCB（將來銀行）的客戶服務整合 API 伺服器專案，使用 .NET Framework 4.7.2 建置的 ASP.NET Web API 應用程式。

## 專案結構

專案包含四個主要子專案：

- **NCB.CSI.ApServer** - 主要的 Web API 伺服器
- **NCB.CSI.Models** - 共用的資料模型
- **NCB.CSI.Batch** - 批次處理程式
- **NCB.CSI.ApClient** - 客戶端程式庫

## 架構設計

### API 整合架構

系統整合多個外部服務：

- **BMS** (Business Management System) - 業務管理系統，包含開戶、會員、貸款等功能
- **CBS** (Core Banking System) - 核心銀行系統
- **ESB** (Enterprise Service Bus) - 企業服務匯流排，處理銀行卡、帳戶、貸款等核心業務
- **CM** (Content Management) - 內容管理系統，處理檔案上傳下載
- **MIP** (Message Integration Platform) - 訊息整合平台，處理推播、簡訊、郵件
- **OTP** (One-Time Password) - 動態密碼服務

### 技術堆疊

- ASP.NET Web API 5.2.7
- AutoMapper 10.0.0
- FluentValidation 8.6.1
- Swagger-Net 8.3.25.2
- Newtonsoft.Json 12.0.3
- NLog (日誌記錄)
- Devpro 框架 (自定義框架)

## 常用命令

### 建置專案

```bash
# 使用 Visual Studio 或 MSBuild 建置
msbuild NCB.CSI.ApServer.sln /p:Configuration=Release

# 還原 NuGet 套件
nuget restore NCB.CSI.ApServer.sln
```

### 執行批次作業

```bash
# 執行批次程式範例
NCB.CSI.Batch.exe GetCaseList --casestatus B --from -10 --to 0 --campaign H0501 --wave WAVE1 --department H0504
NCB.CSI.Batch.exe GetLoanInfo --campaign LOAN01 --wave WAVE1 --department H0504
```

### Fortify 安全掃描準備

```bash
# 執行 Fortify.bat 清理不必要的檔案並設定 debug=false
Fortify.bat
```

### 設定檔加密/解密

```bash
# 加密設定檔
設定檔加密.bat

# 解密設定檔  
設定檔解密.bat
```

## 重要設定

主要設定位於 `NCB.CSI.ApServer/Web.config`：

- 資料庫連線字串 (`CSIDB`, `NLog`)
- 各服務的基礎位址 (BaseAddress)
- Token 密鑰 (`TokenSecret`)
- ESB 相關設定 (ChannelID, ConsumerID, CustId)
- OTP API Key

## API 路由結構

預設路由模式：`api/{controller}/{action}/{id}`

主要控制器分類：

- **Bms*** - BMS 系統相關 API
- **Esb*** - ESB 系統相關 API
- **CM** - 內容管理 API
- **MIP** - 訊息平台 API
- **OTP** - 動態密碼 API
- **Cbs** - 核心銀行系統 API
- **Privilege** - 權限管理 API

## 驗證與錯誤處理

- 使用 FluentValidation 進行模型驗證
- 使用 LogHttpMessagesHandler 記錄 HTTP 訊息
- NLog 用於應用程式日誌記錄

## 安全性考量

- HTTP Cookies 設定為 httpOnlyCookies="true" 和 requireSSL="true"
- 使用 HTTPS 連線外部服務
- 敏感資訊（如 Token、密碼）儲存在設定檔中，支援加密

## 批次排程系統

### 批次作業類型

系統支援多種批次作業類型，使用 CommandLine 參數解析：

1. **GetCaseList** - 匯入開戶申請案件

   - 從 BMS 系統取得指定時間範圍內的案件
   - 自動判斷案件類型（一般、AML、特殊案件）
   - 參數：casestatus, from, to, campaign, wave, department
2. **GetLoanInfo** - 匯入貸款案件

   - 從 BMS 系統取得貸款申請資料
   - 參數：campaign, wave, department
3. **GetAmlCases** - 匯入 AML 風險案件

   - 透過 SFTP 讀取 CSV 檔案
   - 支援自訂分隔符號和欄位數驗證
   - 參數：host, username, password, filepath, prefix, extension, datediff, fieldCount, separator, campaign, wave, department
4. **GetAmlBlackCases** - 匯入 AML 黑名單

   - 透過 SFTP 讀取 Tab 分隔檔案
   - 包含重複檢查機制
   - 檔案格式：24 個欄位，Tab 分隔
5. **GetWTMInsuranceCases** - 匯入保險電訪名單

   - 透過 SFTP 讀取檔案
   - 檔案格式：41 個欄位，Tab 分隔
   - 包含詳細的客戶資料和保險資訊
6. **SyncWTMInsuranceCases** - 同步保險案件

   - 參數：count (同步筆數)
7. **SyncWTMInsuranceCasesNotDial** - 同步未撥打電訪名單

   - 參數：campaign (支援多個活動代碼，逗號分隔)

### 執行範例

```mermaid
# 取得開戶案件（最近 10 分鐘內的案件）
NCB.CSI.Batch.exe GetCaseList --casestatus B --from -10 --to 0 --campaign H0501 --wave WAVE1 --department H0504

# 取得貸款案件
NCB.CSI.Batch.exe GetLoanInfo --campaign LOAN01 --wave WAVE1 --department H0504

# 匯入 AML 風險案件（前一天的檔案）
NCB.CSI.Batch.exe GetAmlCases --host 10.40.12.216 --username opt_ftc --password [密碼] --filepath "/aml_ftc/download/aml/" --prefix RiskElevation_ --extension .csv --datediff -1 --fieldCount 5 --separator , --campaign H0502 --wave WAVE1 --department H0504

# 同步保險案件
NCB.CSI.Batch.exe SyncWTMInsuranceCases --count 100
```

### 特殊案件判斷邏輯

系統會自動判斷特殊案件並分配到不同的活動代碼：

- **AML 案件** (H0504)：manualReviewFlag.aml > 0
- **特殊案件** (H0503)：
  - p2566: 他行帳戶驗證失敗十次以上
  - bornInUSA: 需補棄籍證明
  - z22 > 0: Z22發查回覆人工審核
  - sameIpWithDiffPid: 同一IP不同ID在7日內開戶
  - rarelyWord: 客戶資訊含難字
  - z21ExceedTimes: Z21放行原因

## 檔案格式與資料交換

### 支援的檔案格式

1. **CSV 檔案**

   - AML 風險案件：5 個欄位，逗號分隔
   - 支援自訂分隔符號
2. **Tab 分隔檔案 (TSV)**

   - AML 黑名單：24 個欄位
   - 保險電訪名單：41 個欄位
   - 欄位包含：客戶基本資料、聯絡資訊、業務資料等
3. **JSON 格式**

   - API 請求/回應格式
   - 批次作業的 JsonData 欄位儲存原始資料
4. **XML 格式**

   - Web.config、App.config 設定檔
   - NuGet packages.config
   - ESB 服務規格文件
5. **Excel 檔案 (XLSX)**

   - ESB API 規格文件
   - 中台資料表相關資訊
   - 業務流程文件

### SFTP 檔案處理

系統使用 Renci.SshNet 進行 SFTP 連線：

- 支援檔案名稱模式：`{prefix}{yyyyMMdd}{extension}`
- 自動計算檔案日期（支援 datediff 參數）
- 檔案存在性檢查
- 自動編碼處理（UTF-8）

### 資料驗證機制

1. **欄位數驗證**：確保檔案欄位數符合預期
2. **重複檢查**：避免重複匯入相同案件
3. **資料轉換**：自動轉換日期、數字格式
4. **錯誤記錄**：使用 NLog 記錄所有操作和錯誤

### 日誌管理

- 使用 NLog 進行日誌記錄
- 動態設定 LogFileName（根據執行的批次類型）
- 記錄所有 API 呼叫的請求和回應
- 支援資料庫日誌儲存
