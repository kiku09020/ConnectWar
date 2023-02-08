using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMatchineBase<T> :MonoBehaviour where T:IStateBase
{
	/// <summary>
	/// ���݂̏��
	/// </summary>
	public T NowState { get; protected set; }

	/// <summary>
	/// ��Ԃ̏�����
	/// </summary>
	/// /// <param name="initState">�������</param>
	public void StateInit(T state)
	{
		NowState = state;
		NowState.StateEnter();
	}

	/// <summary>
	/// ���݂̏�Ԃ̍X�V����
	/// </summary>
	public void StateUpdate()
	{
		NowState.StateUpdate();
	}

	/// <summary>
	/// ��ԑJ��
	/// </summary>
	/// <param name="nextState">���̏��</param>
	public void StateTransition(T nextState)
	{
		NowState.StateExit();
		NowState = nextState;
		NowState.StateEnter();
	}

}
