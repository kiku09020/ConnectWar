using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : FactoryWithList
{
    [SerializeField] List<BlockBase> blocks = new List<BlockBase>();

    //--------------------------------------------------

    private void Awake()
    {
        // ƒuƒƒbƒN‚Ì‰Šú‰»
        foreach(var block in blocks) {
            block.Initialize();
        }
    }

    public override ProductBase GetProduct(Vector3 pos, Quaternion rot, Transform parent)
    {
        throw new System.NotImplementedException();
    }
}
