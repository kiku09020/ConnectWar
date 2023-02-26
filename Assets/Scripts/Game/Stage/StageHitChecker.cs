using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class StageHitChecker : HitCheckerBase
{
	[SerializeField] Grid grid;
	[SerializeField] Tilemap tilemap;
	[SerializeField] Tile tile;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (CheckLayerMask(TargetLayer, collision.gameObject.layer)) {
			IsHit = true;

			var block = collision.gameObject;
			var pos = grid.WorldToCell(block.transform.position);

			tile.color = block.GetComponent<SpriteRenderer>().color;
			tilemap.SetTile(pos, tile);

			Destroy(block);

			MainGameManager.ChangeTurn();
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		IsHit = false;
	}
}
