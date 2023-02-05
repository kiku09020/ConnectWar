using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �C���X�^���X�̏�Ԃ̑�������܂��B
/// </summary>
public class StateControllerBase : MonoBehaviour
{
	/// <summary>
	/// ���݂̏��
	/// </summary>
	public IStateBase NowState { get; private set; }

	/// <summary>
	/// ��Ԃ̏�����
	/// </summary>
	/// /// <param name="initState">�������</param>
	public void StateInit(IStateBase initState)
	{
		NowState = initState;
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
	public void StateTransition(IStateBase nextState)
	{
		NowState.StateExit();
		NowState = nextState;
		NowState.StateEnter();
	}
}
