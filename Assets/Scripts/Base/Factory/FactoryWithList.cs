using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FactoryWithList : FactoryBase
{
	List<ProductBase> generatedProductList = new List<ProductBase>();

	/// <summary>
	/// �������ꂽ�I�u�W�F�N�g��List
	/// </summary>
	public List<ProductBase> GeneratedProductList => generatedProductList;

	/// <summary>
	/// �������ꂽ�I�u�W�F�N�g��List�ɒǉ�����
	/// </summary>
	protected void AddToGeneratedList(ProductBase generatedProduct)
	{
		generatedProductList.Add(generatedProduct);
	}
}
