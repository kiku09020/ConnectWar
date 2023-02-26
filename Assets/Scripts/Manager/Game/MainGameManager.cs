using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using GameController;

public class MainGameManager : SimpleSingleton<MainGameManager>
{
    [SerializeField] GameStateMachine state;        // ゲームステート

    [SerializeField] bool isPermanent;

    public bool IsPermanent => isPermanent;

    public static bool IsTurn { get; private set; }        // プレイヤーのターンか

    private void Start()
    {
        IsTurn = true;

        BGM.Instance.Play(AudioNames.BGM_PALETTE,0,0.5f,1);     // BGM再生
    }

	void FixedUpdate()
    {
        state.StateUpdate();            // 状態更新
    }
    
    /// <summary>
    /// ターン変更
    /// </summary>
    public static void ChangeTurn()
	{
		if (!Instance.isPermanent) {
            IsTurn = !IsTurn;
		}
	}
}
