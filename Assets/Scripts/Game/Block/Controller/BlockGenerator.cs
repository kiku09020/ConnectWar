using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : FactoryWithList
{
    [SerializeField] List<BlockBase> blocks = new List<BlockBase>();
    [SerializeField] SpriteRenderer rend;

    //--------------------------------------------------

    private void Awake()
    {
        // ÉuÉçÉbÉNÇÃèâä˙âª
        foreach(var block in blocks) {
            block.Initialize();
        }
    }

    public void Generate()
    {
        GetProduct(transform.position, Quaternion.identity);
    }

    public override ProductBase GetProduct(Vector3 pos, Quaternion rot, Transform parent = null)
    {
        var block = Instantiate(blocks[0], pos, rot, parent);

        block.SetBlockColor(rend.color);
        block.Initialize();

        return block;
    }
}
