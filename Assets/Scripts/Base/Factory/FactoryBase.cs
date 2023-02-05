using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FactoryBase : MonoBehaviour
{
	List<IProduct> generatedObjectList = new List<IProduct>();

	/// <summary>
	/// �������ꂽ�I�u�W�F�N�g�̃��X�g
	/// </summary>
	public List<IProduct> GeneratedObjectList => generatedObjectList;

	/// <summary>
	/// ����
	/// </summary>
	public abstract IProduct GetProduct(Vector3 pos, Quaternion rot, Transform parent);

	/// <summary>
	/// �������ꂽ�I�u�W�F�N�g�����X�g�ɒǉ�����
	/// </summary>
	protected virtual void AddToGeneratedList(IProduct generatedObj)
	{
		generatedObjectList.Add(generatedObj);
	}
}
