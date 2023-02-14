using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeController
{
	/// <summary>
	/// ��~����Ă��邩
	/// </summary>
    public static bool IsStoping { get; private set; }

	/// <summary>
	/// �ύX����Ă��邩
	/// </summary>
	public static bool IsChanged { get; private set; }

	//--------------------------------------------------
	/// <summary>
	/// ���Ԓ�~
	/// </summary>
	public static void Stop(bool isStop)
	{
		Time.timeScale = 0;
		IsStoping = true;
		IsChanged = true;
	}

	/// <summary>
	/// ���Ԓ�~�B���Ԓ�~���ɌĂяo���ƁA��~�I��
	/// </summary>
	public static void Stop()
	{
		// ��~�I��
		if (IsStoping) {
			ResetTimeScale();
		}

		// ��~
		else {
			Time.timeScale = 0;
			IsStoping = true;
			IsChanged = true;
		}
	}

	/// <summary>
	/// TimeScale�����ɖ߂�
	/// </summary>
	public static void ResetTimeScale()
	{
		Time.timeScale = 1;
		IsStoping = false;
		IsChanged = false;
	}

	/// <summary>
	/// �ړI��TimeScale�ɐݒ�
	/// </summary>
	/// <param name="timeScale"></param>
	public static void ChangeTimeScale(float timeScale, bool enableReset = false)
	{
		// ���Ԃ����ɖ߂�
		if (enableReset && IsChanged) {
			ResetTimeScale();
		}

		else {
			// ���ԕύX
			Time.timeScale = timeScale;
			IsChanged = true;
		}
	}
}
