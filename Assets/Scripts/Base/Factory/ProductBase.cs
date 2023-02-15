using UnityEngine;

public abstract class ProductBase :MonoBehaviour
{
    /// <summary>
    /// 初期化(Factoryで呼び出される)
    /// </summary>
    public abstract void Initialize();

    /// <summary>
    /// 生成されたときの処理
    /// </summary>
    public abstract void Generated();
}
