using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonBase : MonoBehaviour
{
	[Header("������")]
    [SerializeField] UnityEvent holdingEvent;
	[SerializeField] int waitFrame;
	int holdingFrame;

	// �t���O
	public bool IsPressed { get; private set; }
	public bool IsHeld { get; private set; }
	bool isHeldOnce;

	//--------------------------------------------------

	private void FixedUpdate()
	{
		HoldCheck();

		if (IsHeld) {
			holdingEvent.Invoke();
		}
	}

	void HoldCheck()
	{
		// ���͂���Ă���
		if (IsPressed) {
			holdingFrame++;

			// ������
			if (holdingFrame > waitFrame) {
				IsHeld = true;

				// ��������x�̂�
				if (!isHeldOnce) {
					isHeldOnce = true;
				}

				else {
					isHeldOnce = false;
				}
			}
		}
	}

	public void OnClick()
	{
       
	}

    public void OnPointerDown()
	{
		IsPressed = true;
	}

    public void OnPointerUp()
	{
		IsPressed = false;
        IsHeld = false;
		isHeldOnce = false;
		holdingFrame = 0;
	}
}
