using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheckerBase : MonoBehaviour
{
    [SerializeField] protected Collider2D _collider;

    [SerializeField] LayerMask targetLayer;
    [SerializeField] string targetTag;

	#region Property
	/* 外部参照用プロパティ */
	/// <summary>
	/// Colliderが対象に触れているかどうか
	/// </summary>
	public bool IsHit { get; protected set; }

    /// <summary>
    /// ColliderのEnabled
    /// </summary>
    public bool CollisionEnabled { get => _collider.enabled; set => _collider.enabled = value; }

    /* For Editor */
    public Collider2D Collider      { get => _collider; set => _collider = value; }
    public LayerMask TargetLayer    { get => targetLayer; set => targetLayer = value; }
    public string TargetTag         { get => targetTag; set => targetTag = value; }
	#endregion

	//--------------------------------------------------
	protected virtual void Awake()
    {
        IsHit = false;
        CollisionEnabled = true;
    }

    /// <summary>
    /// <paramref name="layerMask"/>に<paramref name="targetLayer"/>が含まれているか
    /// </summary>
    public static bool CheckLayerMask(LayerMask layerMask,int targetLayer)
	{
        return ((1 << targetLayer) & layerMask) > 0;
	}
}
