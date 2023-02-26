using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class StageHitChecker : HitCheckerBase
{
	[Header("Tilemap")]
	[SerializeField] Grid grid;
	[SerializeField] Tilemap tilemap;
	[SerializeField] Tile tile;

	[SerializeField] CPU cpu;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (CheckLayerMask(TargetLayer, collision.gameObject.layer)) {
			IsHit = true;

			SetBlockToTile(collision.gameObject);		// タイルに登録
			
			MainGameManager.ChangeTurn();               // ターン変更
			cpu.OperateCPU();
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		IsHit = false;

		tile.color = Color.white;
	}

	// ブロックをタイルにセット
	void SetBlockToTile(GameObject obj)
	{
		var block = obj;
		var pos = grid.WorldToCell(block.transform.position);

		tile.color = block.GetComponent<SpriteRenderer>().color;
		tilemap.SetTile(pos, tile);

		Destroy(block);
	}
}
