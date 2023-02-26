using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using GameController;

public class MainGameManager : SimpleSingleton<MainGameManager>
{
    [SerializeField] GameStateMachine state;        // �Q�[���X�e�[�g

    [SerializeField] bool isPermanent;

    public bool IsPermanent => isPermanent;

    public static bool IsTurn { get; private set; }        // �v���C���[�̃^�[����

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
