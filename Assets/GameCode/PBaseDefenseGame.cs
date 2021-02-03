using UnityEngine;

public class PBaseDefenseGame
{
	//------------------------------------------------------------------------
	// Singleton模版
	private static PBaseDefenseGame _instance;
	public static PBaseDefenseGame Instance
	{
		get
		{
			if (_instance == null)
				_instance = new PBaseDefenseGame();
			return _instance;
		}
	}

	// 場景狀態控制
	private bool m_bGameOver = false;

	// 遊戲系統
	private PBaseDefenseGame()
	{ }

	// 初始P-BaseDefense遊戲相關設定
	public void Initinal()
	{
		// 場景狀態控制
		m_bGameOver = false;
	}

	// 註冊遊戲事件系統
	private void ResigerGameEvent()
	{
	}

	// 釋放遊戲系統
	public void Release()
	{

	}

	// 更新
	public void Update()
	{
	}

	// 玩家輸入
	private void InputProcess()
	{
	}

	// 遊戲狀態
	public bool ThisGameIsOver()
	{
		return m_bGameOver;
	}

	// 換回主選單
	public void ChangeToMainMenu()
	{
		m_bGameOver = true;
	}
}
