using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CPU : MonoBehaviour
{
    [Header("tilemaps")]
    [SerializeField] Tilemap tilemap;

    [SerializeField] Stage stage;

    [Header("Generators")]
    [SerializeField] BlockGenerator cpuBlockGenerator;
    [SerializeField] BlockGenerator playerBlockGenerator;

    //--------------------------------------------------

    void Awake()
    {
        
    }


    public void OperateCPU()
	{
        StartCoroutine(OperateCoroutine());
    }

    IEnumerator OperateCoroutine()
	{
        if (MainGameManager.IsTurn) {
            yield break;
        }

        // 移動
        yield return StartCoroutine(MoveCoroutine());

        // 配置
        yield return StartCoroutine(SetBlock());
    }

    /// <summary>
    /// CPU操作
    /// </summary>
    IEnumerator MoveCoroutine()
    {
        var targetX = GetBestPosition();
        var currentPos = stage.GetGridPosition(cpuBlockGenerator.transform.position);

        var dist = Mathf.Abs(currentPos.x - targetX);

        // 移動
        for (int i = 0; i < dist; i++) {
            yield return StartCoroutine(Move(currentPos.x, targetX));
            currentPos.x += (currentPos.x < targetX) ? 1 : -1;      // 方向ごとに加算する
        }


    }

    // 移動
    IEnumerator Move(int currentPosX, int targetPosX)
    {
        yield return new WaitForSeconds(0.5f);

        if (currentPosX < targetPosX) {
            cpuBlockGenerator.Mover.MoveRight();
        }

        else {
            cpuBlockGenerator.Mover.MoveLeft();
        }

    }

    // ブロック配置
    IEnumerator SetBlock()
    {
        yield return new WaitForSeconds(1);

        cpuBlockGenerator.Generate(false);
    }

    // いい位置探す
    int GetBestPosition()
	{
        var highScore = int.MinValue;
        var column = 0;

        for(int x = 0; x < stage.GetBounds().size.y; x++) {
            var score = AlphaBeta(tilemap, 3, int.MinValue, int.MaxValue, false);

			if (score > highScore) {
                highScore = score;
                column = x;
			}
		}

        return column;
	}

    // 探索
    int AlphaBeta(Tilemap tilemap,int depth,int alpha,int beta,bool isMaximizing)
	{
		if (depth == 0) {
            return Evaluate(tilemap);
		}

        var width = stage.GetBounds().size.x;

        // alpha(cpu)
		if (isMaximizing) {
            var highScore = int.MaxValue;

            for (int x = 0; x < width; x++) {
                if (Stage.CanDropBlock(tilemap, x)) {
                    var score = AlphaBeta(tilemap, depth-1, alpha, beta, false);
                    highScore = Mathf.Max(alpha, score);
                    alpha = Mathf.Max(alpha, score);

                    if (beta <= alpha) {
                        break;
                    }
                }
            }

            return highScore;
        }

        // beta(player)
		else {
            var worstScore = int.MinValue;

            for(int x = 0; x < width; x++) {
				if (Stage.CanDropBlock(tilemap, x)) {
                    var score = AlphaBeta(tilemap, depth-1, alpha, beta, true);
                    worstScore = Mathf.Min(worstScore, score);
                    beta = Mathf.Min(beta, score);

					if (beta <= alpha) {
                        break;
					}
				}
			}

            return worstScore;
		}
	}


    // 評価
    int Evaluate(Tilemap tilemap)
	{
        int score = 0;

        var tiles = tilemap.GetTilesBlock(stage.GetBounds());

        foreach(var tileBase in tiles ) {
            if (tileBase) {
                var tile = tileBase as Tile;
                var tilePos = Vector2Int.CeilToInt(tile.transform.GetPosition());

                if (tile.color == cpuBlockGenerator.Renderer.color) {
                    score += Stage.GetConnectedCount(tilePos, tilemap, cpuBlockGenerator.Renderer.color);
                }

                else if (tile.color == playerBlockGenerator.Renderer.color) {
                    score -= Stage.GetConnectedCount(tilePos, tilemap, playerBlockGenerator.Renderer.color);
                }
            }
		}

        return score;
	}
}
