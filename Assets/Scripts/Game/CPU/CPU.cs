using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CPU : MonoBehaviour
{
    [Header("tilemaps")]
    [SerializeField] Tilemap cpuTilemap;
    [SerializeField] Tilemap playerTilemap;

    int targetX;

    //--------------------------------------------------

    void Awake()
    {
        
    }

    void Update()
    {
        
    }

    // 配置位置を取得する
    void GetTargetPosition()
	{

	}
}
