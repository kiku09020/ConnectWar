using UnityEngine;

public abstract class ProductBase :MonoBehaviour
{
    /// <summary>
    /// ������(Factory�ŌĂяo�����)
    /// </summary>
    public abstract void Initialize();

    /// <summary>
    /// �������ꂽ�Ƃ��̏���
    /// </summary>
    public abstract void Generated();
}
