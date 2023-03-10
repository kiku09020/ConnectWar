using UnityEngine;

public abstract class ProductBase :MonoBehaviour
{
    /// <summary>
    /// 初期化(Awake,Startで呼び出される)
    /// </summary>
    public abstract void Initialize();

    /// <summary>
    /// 生成時(GetProductで呼び出される)
    /// </summary>
    public abstract void Generated(IFactoryInfo genInfo);
}
