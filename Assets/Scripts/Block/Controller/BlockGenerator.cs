using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : FactoryWithList
{
    const int blockCount = 3;
    [NonReorderable,SerializeField] BlockBase[] blocks = new BlockBase[blockCount];

    //--------------------------------------------------

    private void Awake()
    {
        // ÉuÉçÉbÉNÇÃèâä˙âª
        foreach(var block in blocks) {
            block.Initialize();
        }
    }

    public override ProductBase GetProduct(Vector3 pos, Quaternion rot, Transform parent)
    {
        throw new System.NotImplementedException();
    }
}
