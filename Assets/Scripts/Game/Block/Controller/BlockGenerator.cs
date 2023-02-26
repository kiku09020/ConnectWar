using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockGenerator : FactoryWithList,IBlockGeneratorInfo
{
    [SerializeField] List<BlockBase> blocks = new List<BlockBase>();

    [Header("Components")]
    [SerializeField] SpriteRenderer rend;
    [SerializeField] BlockGeneratorMover mover;

    public BlockGeneratorMover Mover => mover;
    public SpriteRenderer Renderer => rend;

    //--------------------------------------------------

    private void Awake()
    {
        // ÉuÉçÉbÉNÇÃèâä˙âª
        foreach(var block in blocks) {
            block.Initialize();
        }
    }

    public void Generate(bool isPlayer)
    {
        if (MainGameManager.IsTurn == isPlayer) {
            GetProduct(transform.position, Quaternion.identity);
		}
    }

    public override ProductBase GetProduct(Vector3 pos, Quaternion rot, Transform parent = null)
    {
        var targetPos = new Vector3(pos.x, pos.y - 1, pos.z);
        var block = Instantiate(blocks[0], targetPos, rot, parent);

        block.Generated(this);

        return block;
    }
}
