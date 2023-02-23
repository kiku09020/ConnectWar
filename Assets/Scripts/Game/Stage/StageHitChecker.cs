using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageHitChecker : HitCheckerBase
{
	GameObject hitBlock;

	public GameObject HitBlock => hitBlock;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (CheckLayerMask(TargetLayer, collision.gameObject.layer)) {
			IsHit = true;
			hitBlock = collision.gameObject;

			Destroy(collision.gameObject);
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		IsHit = false;
		hitBlock = null;
	}
}
