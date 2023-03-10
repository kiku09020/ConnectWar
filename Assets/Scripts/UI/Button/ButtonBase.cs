using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonBase : MonoBehaviour
{
	[Header("長押し")]
    [SerializeField] UnityEvent holdingEvent;
	[SerializeField] int waitFrame;
	int holdingFrame;

	// フラグ
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
		// 入力されている
		if (IsPressed) {
			holdingFrame++;

			// 長押し
			if (holdingFrame > waitFrame) {
				IsHeld = true;

				// 長押し一度のみ
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
