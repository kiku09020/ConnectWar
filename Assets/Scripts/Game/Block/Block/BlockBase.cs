using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BlockBase : ProductBase 
{
    protected BlockData data;

	[SerializeField] SpriteRenderer rend;

	public override void Initialize(IFactoryInfo generatorInfo) 
    {
        data = BlockData_ScObj.LoadData(this);
		SetBlockColor(generatorInfo as IBlockGeneratorInfo);
    }

	public override void Generated()
	{
		
	}

	void SetBlockColor(IBlockGeneratorInfo info)
	{
		var color = info.Renderer.color;
        var blockColor = new Color(color.r, color.g, color.b, 1);
        rend.color = blockColor;
	}
}
