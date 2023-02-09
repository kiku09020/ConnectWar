using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioListener))]
public class AudioController : Singleton<AudioController>
{

    /// <summary>
    /// �S�Ẳ������ꎞ��~
    /// </summary>
    public static void PauseAllAudio()
    {
        BGM.Instance.Pause();
        SE.Instance.Pause();
    }

    /// <summary>
    /// �S�Ẳ����̈ꎞ��~������
    /// </summary>
    public static void UnPauseAllAudio()
    {
        BGM.Instance.UnPause();
        SE.Instance.UnPause();
    }

    /// <summary>
    /// �S�Ẳ������~
    /// </summary>
    public static void StopAllAudio()
    {
        BGM.Instance.Stop();
        SE.Instance.Stop();
    }
}
