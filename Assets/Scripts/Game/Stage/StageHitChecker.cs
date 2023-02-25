using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class StageHitChecker : HitCheckerBase
{
	[SerializeField] Grid grid;
	[SerializeField] Tilemap tilemap;
	[SerializeField] Tile tile;

	GameObject hitBlock;

	public GameObject HitBlock => hitBlock;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (CheckLayerMask(TargetLayer, collision.gameObject.layer)) {
			IsHit = true;
			hitBlock = collision.gameObject;

			var pos = grid.WorldToCell(hitBlock.transform.position);
			tilemap.SetTile(pos, tile);


			Destroy(collision.gameObject);
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		IsHit = false;
		hitBlock = null;
	}
}
