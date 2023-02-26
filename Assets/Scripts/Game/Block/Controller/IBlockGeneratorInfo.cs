using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFactoryInfo {
	Transform Transform { get; }
}

public interface IBlockGeneratorInfo :IFactoryInfo
{
	SpriteRenderer Renderer { get; }

}
