using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Stage : MonoBehaviour
{
	[Header("Tilemap")]
	[SerializeField] Tilemap tilemap;

    public enum TilemapType {
        player,
        rival,
        stage,
	}

    //--------------------------------------------------

    void Awake()
    {
		
    }

	/// <summary>
	/// �S�Ẵ^�C���}�b�v���܂Ƃ߂��^�C���}�b�v���擾
	/// </summary>
	//public Tilemap GetTilemap()
	//{
	//	tilemap.CompressBounds();

	//	var bounds = tilemap.cellBounds;
	//	var tiles = tilemap.GetTilesBlock(bounds);

	//	for (int y = bounds.yMin; y < bounds.yMax; y++) {
	//		for (int x = bounds.xMin; x < bounds.xMax; x++) {
	//			var tilePosition = new Vector3Int(x, y);
	//			var tile = tiles[(x - bounds.xMin) + (y - bounds.yMin) * bounds.size.x] as Tile;
	//		}
	//	}

	//	return tilemap;
	//}

    /// <summary>
    /// �w��̃^�C���}�b�v�̎w��̈ʒu�̃^�C�����擾
    /// </summary>
    public TileBase GetTile(TilemapType type,Vector3Int tilePosition)
	{
        return tilemap.GetTile(tilePosition);
	}
}
