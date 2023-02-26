using UnityEngine;

public abstract class ProductBase :MonoBehaviour
{
    /// <summary>
    /// ‰Šú‰»(Awake,Start‚ÅŒÄ‚Ño‚³‚ê‚é)
    /// </summary>
    public abstract void Initialize(IFactoryInfo genInfo);

    /// <summary>
    /// ¶¬(GetProduct‚ÅŒÄ‚Ño‚³‚ê‚é)
    /// </summary>
    public abstract void Generated();
}
