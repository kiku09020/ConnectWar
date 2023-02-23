using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Stage : MonoBehaviour
{
    [Header("Tilemap")]
    [SerializeField] Tilemap tilemap;       // �^�C���}�b�v
    TileBase[] tiles;                       // �^�C���z��

    BoundsInt bounds;                       // BoundingBox. cellsize���킩��

    //--------------------------------------------------

    void Awake()
    {
        Setup();
    }

    void Setup()
	{
        bounds = tilemap.cellBounds;                // �T�C�Y�擾
        tiles = tilemap.GetTilesBlock(bounds);      // �^�C�����擾
    }
}
