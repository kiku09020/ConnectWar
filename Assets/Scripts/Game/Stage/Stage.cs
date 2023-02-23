using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Stage : MonoBehaviour
{
    [Header("Tilemap")]
    [SerializeField] Tilemap tilemap;       // タイルマップ
    TileBase[] tiles;                       // タイル配列

    BoundsInt bounds;                       // BoundingBox. cellsizeがわかる

    //--------------------------------------------------

    void Awake()
    {
        Setup();
    }

    void Setup()
	{
        bounds = tilemap.cellBounds;                // サイズ取得
        tiles = tilemap.GetTilesBlock(bounds);      // タイル情報取得
    }
}
