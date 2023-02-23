using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : FactoryWithList
{
    [SerializeField] List<BlockBase> blocks = new List<BlockBase>();

    [SerializeField] Transform parent;

    //--------------------------------------------------

    private void Awake()
    {
        // ƒuƒƒbƒN‚Ì‰Šú‰»
        foreach(var block in blocks) {
            block.Initialize();
        }
    }

    public void Generate()
    {
        GetProduct(transform.position, Quaternion.identity, parent);
    }

    public override ProductBase GetProduct(Vector3 pos, Quaternion rot, Transform parent)
    {
        var block = Instantiate(blocks[0], pos, rot, parent);

        block.Initialize();

        return block;
    }
}
