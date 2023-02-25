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
            LogController.ColoredLog($"{FILENAME}Ç™éÊìæÇ≈Ç´Ç‹ÇπÇÒÇ≈ÇµÇΩ", Color.red, LogTag.Data);
            return null;
        }

        foreach(var blockData in scrptObj.blockDataList) {
            if (blockData.Name + "Block" == blockTypeName) {
                return blockData;
            }
        }

        LogController.ColoredLog($"{blockTypeName}ÇÃÉfÅ[É^ÇÕå©Ç¬Ç©ÇËÇ‹ÇπÇÒÇ≈ÇµÇΩ", Color.red, LogTag.Data);
        return null;
    }
}
