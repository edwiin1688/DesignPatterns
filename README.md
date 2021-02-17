# DesignPatterns
設計模式

專案 [DesignPatterns](https://github.com/edwiin1688/DesignPatterns) 目前引用函示庫 [DesignPatternsLibrary](https://github.com/edwiin1688/DesignPatternsLibrary)

## 🎬遊戲場景的轉換 - State 狀態模式
先行定義了一個 ISceneState 介面
StartState(開始場景)、MainMenuState(主畫面)、BattleState(戰鬥場景) 都繼承了 ISceneState 介面

## 🎬遊戲場景的轉換 - State 狀態模式
1. 先行定義了一個 ISceneState 介面(`在 DesignPatternsLibrary 中已定義`)
2. 假定需要三個場景，分別為 StartState(開始場景)、MainMenuState(主畫面)、BattleState(戰鬥場景) 都繼承了 ISceneState 介面
3. 建立 Unity3D - Scene 為  StartScene 並掛上 GameLoop 腳本(主要是載入 StartState 場景物件)
4. 定義切換場景流程與內容:
* StartState 切換場景 MainMenuState 。
* 而 MainMenuState 則切換場景 BattleState 。
* 最後 BattleState 依據遊戲結果決定是否回到 MainMenuState 。
5. 建立 MainMenuScene 的 Unity3D - Scene(包含開始按鈕)
6. 建立 BattleScene 的 Unity3D - Scene(包含戰鬥物件，如:BackGroundImage等等)
7. MainMenuState 定義一個進入 BattleState 的開始 UI 按鈕，點擊後進入 BattleState 。
* BattleState 需要初始化 BaseGame 的 Singleton 物件

### 使用狀態模式(State)的優點:
1. 減少錯誤的發生並降低維護成本(不再使用 switch 判斷目前狀態)
2. 狀態執行環境單純化(實作在一個狀態類別下)
3. 專案間可共用場景(配合模板模式與策略模式定義各需求的實作)

### 與其他模式的合作
使用到 BaseGame 的單例模式(Singleton)與外觀模式(Facade)

