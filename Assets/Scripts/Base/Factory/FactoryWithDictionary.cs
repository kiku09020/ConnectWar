using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FactoryWithDictionary : FactoryBase
{
	Dictionary<string, ProductBase> generatedProductsDict = new Dictionary<string, ProductBase>();

	/// <summary>
	/// �������ꂽ�I�u�W�F�N�g��Dictionary
	/// </summary>
	public Dictionary<string, ProductBase> GeneratedProductsDict => generatedProductsDict;

	/// <summary>
	/// �������ꂽ�I�u�W�F�N�g��Dictionary�ɒǉ�����
	/// </summary>
	protected void AddToGeneratedDict(ProductBase generatedProduct, string key)
	{
		generatedProductsDict.Add(key, generatedProduct);
	}
}
