using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateBase
{
	/// <summary>
	/// ���̏�ԂɂȂ����u�Ԃ̏���
	/// </summary>
	public void StateEnter();

	/// <summary>
	/// ���̏�Ԃ̂Ƃ����t���[���Ăяo������
	/// </summary>
	public void StateUpdate();

	/// <summary>
	/// ���̏�Ԃ��甲����u�Ԃ̏���
	/// </summary>
	public void StateExit();
}
