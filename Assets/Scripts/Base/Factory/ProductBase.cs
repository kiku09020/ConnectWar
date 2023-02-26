using UnityEngine;

public abstract class ProductBase :MonoBehaviour
{
    /// <summary>
    /// ������(Awake,Start�ŌĂяo�����)
    /// </summary>
    public abstract void Initialize(IFactoryInfo genInfo);

    /// <summary>
    /// ������(GetProduct�ŌĂяo�����)
    /// </summary>
    public abstract void Generated();
}
