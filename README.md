# BillOrganizer
skilltree bill organizer homework

## Day1.
- 必須使用 Layout
- 下方列表部分建議分開，不要寫在同一頁 並且要有假資料100筆（禁止寫死在 HTML）
- 上方輸入的部分可以只是切版的結果不用實現功能。
- 前方數字是流水號，不是DB的值
- 本次作業禁止使用任何形式的 Database

## Day2.
- 請將記帳本呈現資料的部分改為真 DB !
  - 可使用 EF , ADO.NET
  - 範例資料庫請使用 HomeWorkDB 內的資料
  - 不可改變第一天設計的 ViewModel
- 建議練習
  - 實做 Service 層
- 額外挑戰
  - UnitOfWork
  - Repository
  
## Day3.
- 將記帳本的寫入功能完成。
  - 必須真的寫進資料庫
- 所有欄位必填
  - 「金額」只能輸入正整數
  - 「日期」不得大於今天
  - 「備註」最多輸入100個字元（備註為 TextArea）
- 列表加入顏色變換
  - 類型的「支出」字樣顯現為紅色
  - 類型的「收入」字樣顯現為藍色
- 進階題
  - 將記帳本的寫入功能改為 AJAX。
  - 你將會遇到如何片段更新下方 List 的問題

## Day4.
- 初階版
  - 實做 RSS。
  - 增加管理專用的 Area
  - 管理員可以編輯所有的歷史資料
  - 非管理員進入會「跳回首頁」
- 進階版
  - 登入才可以寫入資料。
  - 如果你已經將寫入改為 AJAX 請嘗試維持 AJAX實做這塊

## Day5.
- 初階版
  - 實做分頁功能
    - 將記帳簿路由改為改為 SkillTree
    - EX：http://localhost/skilltree
  - 增加年月列表功能
    - 可指定年月顯示該年月的所有收支
    - 輸入 http://localhost/skilltree/yyyy/mm 可看到該年月收支
- 進階版
  - 現在你什麼需求都知道了
  - 請使用提供的DB，重寫一個記帳本。
