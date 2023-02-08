using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LogController : MonoBehaviour
{
    public static void Log(object message)
    {
        Debug.Log(message);
    }

    // �F�^�O�ǉ�
    static string AddColorTag(string str, Color color)
    {
        var code = ColorUtility.ToHtmlStringRGBA(color);
        var startStr = $"<color=#{code}>";
        var endStr = "</color>";

        return startStr + str + endStr;
    }

    // �T�C�Y�^�O�ǉ�
    static string AddSizeTag(string str,int size)
    {
        var startStr = $"<size={size}>";
        var endStr = "</size>";

        return startStr + str + endStr;
    }

    /// <summary>
    /// �F�t�����O�\��
    /// </summary>
    public static void ColoredLog(object message,Color color)
    {
        var str= AddColorTag(message.ToString(), color);

        Debug.Log(str);
    }

    /// <summary>
    /// �T�C�Y�w�胍�O�\��
    /// </summary>
    public static void ReSizedLog(object message,int size)
    {
        var str = AddSizeTag(message.ToString(), size);

        Debug.Log(str);
    }

    /// <summary>
    /// �F�ƃT�C�Y�w�肳�ꂽ���O�\��
    /// </summary>
    public static void ColoredAndResizedLog(object message,Color color, int size)
    {
        var coloredStr = AddColorTag(message.ToString(), color);
        var str = AddSizeTag(coloredStr, size);

        Debug.Log(str);
    }

    
}
