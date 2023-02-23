using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BlockData
{
    [SerializeField] string name;       // 名前
    [SerializeField] int cost;          // 生成コスト

    public string Name => name;
}
