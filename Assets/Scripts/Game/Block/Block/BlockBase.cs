using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BlockBase : ProductBase 
{
    protected BlockData data;

	[SerializeField] SpriteRenderer rend;

	public override void Initialize() 
    {
        data = BlockData_ScObj.LoadData(this);
    }

	public override void Generated(IFactoryInfo generatorInfo)
	{
		SetBlockColor(generatorInfo as IBlockGeneratorInfo);
		
	}

	void SetBlockColor(IBlockGeneratorInfo info)
	{
		var color = info.Renderer.color;
        var blockColor = new Color(color.r, color.g, color.b, 1);
        rend.color = blockColor;
	}
}
