using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using GameController;

public class MainGameManager : SimpleSingleton<MainGameManager>
{
    [SerializeField] GameStateMachine state;        // �Q�[���X�e�[�g

    [SerializeField] bool isPermanent;

    /// <summary>
    /// �i�v�Ƀv���C���[�̃^�[���ɂ���
    /// </summary>
    public bool IsPermanent => isPermanent;

    /// <summary>
    /// �v���C���[�̃^�[����
    /// </summary>
    public static bool IsTurn { get; private set; }

    private void Start()
    {
        IsTurn = true;

        BGM.Instance.Play(AudioNames.BGM_PALETTE,0,0.5f,1);     // BGM�Đ�
    }

	void FixedUpdate()
    {
        state.StateUpdate();            // ��ԍX�V
    }
    
    /// <summary>
    /// �^�[���ύX
    /// </summary>
    public static void ChangeTurn()
	{
		if (!Instance.isPermanent) {
            IsTurn = !IsTurn;
		}
	}
}
