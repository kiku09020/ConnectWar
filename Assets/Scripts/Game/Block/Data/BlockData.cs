using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BlockData
{
    [SerializeField] string name;       // ���O
    [SerializeField] int cost;          // �����R�X�g

    public string Name => name;
}
