using UnityEngine;

public abstract class ProductBase :MonoBehaviour
{
    /// <summary>
    /// ‰Šú‰»(Awake,Start‚ÅŒÄ‚Ño‚³‚ê‚é)
    /// </summary>
    public abstract void Initialize();

    /// <summary>
    /// ¶¬(GetProduct‚ÅŒÄ‚Ño‚³‚ê‚é)
    /// </summary>
    public abstract void Generated(IFactoryInfo genInfo);
}
