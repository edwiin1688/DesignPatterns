using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// 主選單狀態
/// </summary>
public class MainMenuState : ISceneState
{
	public MainMenuState(SceneStateController Controller) : base(Controller)
	{
		this.StateName = "MainMenuState";
	}

	/// <summary>
	/// 開始
	/// </summary>
	public override void StateBegin()
	{
		// 取得開始按鈕
		Button tmpBtn_ = UITool.GetUIComponent<Button>("StartGameBtn");
		if (tmpBtn_ != null)
		{
			tmpBtn_.onClick.AddListener(() => OnStartGameBtnClick(tmpBtn_));
		}
	}

	/// <summary>
	/// 開始戰鬥
	/// </summary>
	/// <param name="theButton"></param>
	private void OnStartGameBtnClick(Button theButton)
	{
		Debug.Log ("OnStartBtnClick:"+theButton.gameObject.name);
		m_Controller.SetState(new BattleState(m_Controller), "BattleScene");
	}

}
