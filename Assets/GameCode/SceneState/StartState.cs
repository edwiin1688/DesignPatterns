using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 開始狀態
/// </summary>
public class StartState : ISceneState
{
	public StartState(SceneStateController Controller) : base(Controller)
	{
		this.StateName = "StartState";
	}

	/// <summary>
	/// 開始
	/// </summary>
	public override void StateBegin()
	{
		// 可在此進行遊戲資料載入及初始...等
	}

	/// <summary>
	/// 更新
	/// </summary>
	public override void StateUpdate()
	{
		// 更換為 MainMenuState
		m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene");
	}

}
