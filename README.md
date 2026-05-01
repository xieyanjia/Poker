# Poker

## 一、專案簡介

玩家可以先輸入押注金額，再進行發牌、換牌與判斷牌型。程式會根據玩家最後的牌型判斷結果，搭配不同牌型的賠率，計算中獎金額並更新玩家目前的總資金。

---

## 二、主要功能

### 1. 發牌功能

玩家按下「發牌」按鈕後，系統會從 52 張撲克牌中隨機抽出 5 張牌，並顯示在畫面上的牌桌區域。

發牌前，玩家必須先完成押注，避免沒有下注就直接進入遊戲流程。

### 2. 換牌功能

發牌後，玩家可以點選想要更換的牌。  
被點選的牌會翻成背面，代表該張牌被選為要更換的牌。

按下「換牌」按鈕後，系統會將被選中的牌更換成新的牌，並重新顯示在牌桌上。

### 3. 判斷牌型功能

換牌完成後，玩家可以按下「判斷牌型」按鈕。  
系統會根據目前五張牌的花色與點數判斷牌型，並將結果顯示在畫面上。

可判斷的牌型包含：

- 同花大順
- 同花順
- 鐵支
- 葫蘆
- 同花
- 順子
- 三條
- 兩對
- 一對
- 雜牌

### 4. 下注功能

玩家在每一局開始前，需要先輸入押注金額，並按下「押注」按鈕。

押注時，程式會檢查：

- 押注金額是否為數字
- 押注金額是否大於 0
- 押注金額是否超過目前總資金

押注成功後，系統會先從總資金扣除押注金額，並啟用發牌按鈕。

### 5. 賠率與獎金計算

當玩家完成換牌並判斷牌型後，系統會根據牌型對應賠率計算中獎金額。

牌型賠率如下：

| 牌型 | 賠率 |
|---|---:|
| 同花大順 | 250 |
| 同花順 | 50 |
| 鐵支 | 25 |
| 葫蘆 | 9 |
| 同花 | 6 |
| 順子 | 4 |
| 三條 | 3 |
| 兩對 | 2 |
| 一對 | 1 |
| 雜牌 | 0 |

---

<img width="557" height="525" alt="image" src="https://github.com/user-attachments/assets/1b1f8229-2bb9-453a-86fd-a435795de831" />

<img width="554" height="525" alt="image" src="https://github.com/user-attachments/assets/17acdd86-84b2-48a3-8a9d-f4a75824a196" />

<img width="554" height="524" alt="image" src="https://github.com/user-attachments/assets/1f53092e-af31-4022-a990-17c7956cd769" />

<img width="555" height="524" alt="image" src="https://github.com/user-attachments/assets/ae25f70f-b0de-4f64-bbd6-98ba5b54fe66" />

<img width="554" height="527" alt="image" src="https://github.com/user-attachments/assets/5c66c983-7cd7-44da-ae14-a1fee467aba9" />

<img width="555" height="525" alt="image" src="https://github.com/user-attachments/assets/ebb205f1-35bc-4f80-8458-e14e8c27c18a" />

