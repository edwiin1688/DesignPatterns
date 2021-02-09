using UnityEngine;

/// <summary>
/// 遊戲系統
/// </summary>
public class PBaseDefenseGame : Singleton<PBaseDefenseGame>
{
	/// <summary>
	/// 場景狀態控制
	/// </summary>
	private bool m_bGameOver = false;

	/// <summary>
	/// 初始P-BaseDefense遊戲相關設定
	/// </summary>
	public void Initinal()
	{
		// 場景狀態控制
		m_bGameOver = false;
	}

	/// <summary>
	/// 註冊遊戲事件系統
	/// </summary>
	private void ResigerGameEvent()
	{
	}

	/// <summary>
	/// 釋放遊戲系統
	/// </summary>
	public void Release()
	{

	}

	/// <summary>
	/// 更新
	/// </summary>
	public void Update()
	{
	}

	/// <summary>
	/// 玩家輸入
	/// </summary>
	private void InputProcess()
	{
	}

	/// <summary>
	/// 遊戲狀態
	/// </summary>
	/// <returns></returns>
	public bool ThisGameIsOver()
	{
		return m_bGameOver;
	}

	/// <summary>
	/// 換回主選單
	/// </summary>
	public void ChangeToMainMenu()
	{
		m_bGameOver = true;
	}
}
