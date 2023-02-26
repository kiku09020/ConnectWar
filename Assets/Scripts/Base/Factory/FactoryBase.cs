using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FactoryBase : MonoBehaviour,IFactoryInfo
{
	public Transform Transform => transform;

	/// <summary>
	/// ê∂ê¨
	/// </summary>
	public abstract ProductBase GetProduct(Vector3 pos, Quaternion rot, Transform parent);
}
