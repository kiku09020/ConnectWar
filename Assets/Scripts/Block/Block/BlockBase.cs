using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BlockBase : ProductBase 
{
    protected BlockData data;

    public override void Initialize()
    {
        data = BlockData_ScObj.LoadData(this);
    }

    public override void Generated()
    {
        
    }
}
