using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheckerBase : MonoBehaviour
{
    [SerializeField] protected Collider2D _collider;

    [SerializeField] LayerMask targetLayer;
    [SerializeField] string targetTag;

	#region Property
	/* �O���Q�Ɨp�v���p�e�B */
	/// <summary>
	/// Collider���ΏۂɐG��Ă��邩�ǂ���
	/// </summary>
	public bool IsHit { get; protected set; }

    /// <summary>
    /// Collider��Enabled
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
    /// <paramref name="layerMask"/>��<paramref name="targetLayer"/>���܂܂�Ă��邩
    /// </summary>
    public static bool CheckLayerMask(LayerMask layerMask,int targetLayer)
	{
        return ((1 << targetLayer) & layerMask) > 0;
	}
}
