using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Stage : MonoBehaviour {
	[Header("Tilemap")]
	[SerializeField] Tilemap tilemap;
	[SerializeField] Grid grid;

	public enum TilemapType {
		player,
		rival,
		stage,
	}


	// 方向
	static readonly Vector2Int[] Directions = {
		Vector2Int.right,					// 右
		Vector2Int.up,						// 上
		Vector2Int.up+Vector2Int.right,		// 右上
		Vector2Int.up+Vector2Int.left,		// 左上
	};

	public Tilemap Tilemap => tilemap;

    //--------------------------------------------------

    void Awake()
    {
		
    }

	public BoundsInt GetBounds()
	{
		var bounds = tilemap.cellBounds;
		tilemap.CompressBounds();
		return bounds;
	}

	public Vector3Int GetGridPosition(Vector2 position)
	{
		return grid.WorldToCell(position);
	}

	/// <summary>
	/// ブロック設置可能か
	/// </summary>
	/// <param name="tilemap"></param>
	public static bool CanDropBlock(Tilemap tilemap,int targetX)
	{
		var targetTile = tilemap.GetTile(new Vector3Int(targetX, 0));

		// 指定座標にあれば設置不可
		if (targetTile) {
			return false;
		}

		// なければ設置可能
		return true;
	}

	/// <summary>
	/// 繋がってる数を取得する
	/// </summary>
	public static int GetConnectedCount(Vector2Int tilePos, Tilemap tilemap, Color targetColor)
	{
		var count = 0;
		foreach(var dir in Directions) {
			var targetPos = (Vector3Int)(tilePos + dir);
			var tile = tilemap.GetTile(targetPos) as Tile;

			if (tile?.color == targetColor) {
				count++;
			}
		}

		return count;
	}

	/// <summary>
	/// 指定のタイルマップの指定の位置のタイルを取得
	/// </summary>
	public TileBase GetTile(TilemapType type,Vector3Int tilePosition)
	{
        return tilemap.GetTile(tilePosition);
	}
}
