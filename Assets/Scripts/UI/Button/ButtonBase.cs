using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonBase : MonoBehaviour
{
	[Header("’·‰Ÿ‚µ")]
    [SerializeField] UnityEvent holdingEvent;
	[SerializeField] int waitFrame;
	int holdingFrame;

	// ƒtƒ‰ƒO
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
		// “ü—Í‚³‚ê‚Ä‚¢‚é
		if (IsPressed) {
			holdingFrame++;

			// ’·‰Ÿ‚µ
			if (holdingFrame > waitFrame) {
				IsHeld = true;

				// ’·‰Ÿ‚µˆê“x‚Ì‚Ý
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
