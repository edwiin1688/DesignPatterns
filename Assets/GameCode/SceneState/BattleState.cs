using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 戰鬥狀態
/// </summary>
public class BattleState : ISceneState
{
	public BattleState(SceneStateController Controller) : base(Controller)
	{
		this.StateName = "BattleState";
	}

	/// <summary>
	/// 開始
	/// </summary>
	public override void StateBegin()
	{
		BaseGame.Instance.Initinal();
	}

	/// <summary>
	/// 結束
	/// </summary>
	public override void StateEnd()
	{
		BaseGame.Instance.Release();
	}

	/// <summary>
	/// 更新
	/// </summary>
	public override void StateUpdate()
	{
		// 遊戲邏輯
		BaseGame.Instance.Update();
		// Render由Unity負責

		// 遊戲是否結束
		if (BaseGame.Instance.ThisGameIsOver())
		{
			m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene");
		}
	}
}
