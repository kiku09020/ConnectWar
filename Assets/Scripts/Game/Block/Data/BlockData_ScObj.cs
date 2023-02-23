using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName =FILENAME,menuName ="ScriptableObjcets/Block")]
public class BlockData_ScObj : ScriptableObject
{
    const string FILENAME = "BlockList";

    [SerializeField] List<BlockData> blockDataList;

    public static BlockData LoadData(BlockBase block)
    {
        var blockTypeName = block.GetType().Name;
        var scrptObj = Resources.Load(FILENAME) as BlockData_ScObj;

        if (!scrptObj) {
            LogController.ColoredLog($"{FILENAME}���擾�ł��܂���ł���", Color.red, LogTag.Data);
            return null;
        }

        foreach(var blockData in scrptObj.blockDataList) {
            if (blockData.Name + "Block" == blockTypeName) {
                LogController.ColoredLog($"{blockTypeName}�̃f�[�^���K�p����܂���", Color.yellow, LogTag.Data);
                return blockData;
            }
        }

        LogController.ColoredLog($"{blockTypeName}�̃f�[�^�͌�����܂���ł���", Color.red, LogTag.Data);
        return null;
    }
}
