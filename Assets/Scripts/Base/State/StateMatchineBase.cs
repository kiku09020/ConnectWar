using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMatchineBase<T> :MonoBehaviour where T:IStateBase
{
	/// <summary>
	/// 現在の状態
	/// </summary>
	public T NowState { get; protected set; }

	/// <summary>
	/// 状態の初期化
	/// </summary>
	/// /// <param name="initState">初期状態</param>
	public void StateInit(T state)
	{
		NowState = state;
		NowState.StateEnter();
	}

	/// <summary>
	/// 現在の状態の更新処理
	/// </summary>
	public void StateUpdate()
	{
		NowState.StateUpdate();
	}

	/// <summary>
	/// 状態遷移
	/// </summary>
	/// <param name="nextState">次の状態</param>
	public void StateTransition(T nextState)
	{
		NowState.StateExit();
		NowState = nextState;
		NowState.StateEnter();
	}

}
