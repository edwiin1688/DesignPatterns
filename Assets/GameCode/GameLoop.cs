using System;
using UnityEngine;

/// <summary>
/// 遊戲主迴圈
/// </summary>
public class GameLoop : MonoBehaviour
{
	// 場景狀態
	SceneStateController m_SceneStateController = new SceneStateController();

	// 
	void Awake()
	{
		// 切換場景不會被刪除
		GameObject.DontDestroyOnLoad(this.gameObject);

		// 亂數種子
		UnityEngine.Random.seed = (int)DateTime.Now.Ticks;
	}

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		// 設定起始的場景
		m_SceneStateController.SetState(new StartState(m_SceneStateController), "");
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		m_SceneStateController.StateUpdate();
	}
}
