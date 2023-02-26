using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PutButton : ButtonBase
{
	[SerializeField] Button button;

	//--------------------------------------------------

	private void Awake()
	{
		if (!MainGameManager.Instance.IsPermanent) {
			button.interactable = MainGameManager.IsTurn;
		}
	}

	public void EnableButton()
	{
		button.interactable = MainGameManager.IsTurn;
	}
}
