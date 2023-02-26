using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Stage : MonoBehaviour {
	[Header("Tilemap")]
	[SerializeField] Tilemap tilemap;
	[SerializeField] Grid grid;

	public enum TilemapType {
		player,
		rival,
		stage,
	}


	// ����
	static readonly Vector2Int[] Directions = {
		Vector2Int.right,					// �E
		Vector2Int.up,						// ��
		Vector2Int.up+Vector2Int.right,		// �E��
		Vector2Int.up+Vector2Int.left,		// ����
	};

	public Tilemap Tilemap => tilemap;

    //--------------------------------------------------

    void Awake()
    {
		
    }

	public BoundsInt GetBounds()
	{
		var bounds = tilemap.cellBounds;
		tilemap.CompressBounds();
		return bounds;
	}

	public Vector3Int GetGridPosition(Vector2 position)
	{
		return grid.WorldToCell(position);
	}

	/// <summary>
	/// �u���b�N�ݒu�\��
	/// </summary>
	/// <param name="tilemap"></param>
	public static bool CanDropBlock(Tilemap tilemap,int targetX)
	{
		var targetTile = tilemap.GetTile(new Vector3Int(targetX, 0));

		// �w����W�ɂ���ΐݒu�s��
		if (targetTile) {
			return false;
		}

		// �Ȃ���ΐݒu�\
		return true;
	}

	/// <summary>
	/// �q�����Ă鐔���擾����
	/// </summary>
	public static int GetConnectedCount(Vector2Int tilePos, Tilemap tilemap, Color targetColor)
	{
		var count = 0;
		foreach(var dir in Directions) {
			var targetPos = (Vector3Int)(tilePos + dir);
			var tile = tilemap.GetTile(targetPos) as Tile;

			if (tile?.color == targetColor) {
				count++;
			}
		}

		return count;
	}

	/// <summary>
	/// �w��̃^�C���}�b�v�̎w��̈ʒu�̃^�C�����擾
	/// </summary>
	public TileBase GetTile(TilemapType type,Vector3Int tilePosition)
	{
        return tilemap.GetTile(tilePosition);
	}
}
