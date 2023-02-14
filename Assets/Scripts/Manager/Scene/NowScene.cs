using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class NowScene {
    /// <summary>
    /// ���݂̃V�[�����̃Z�b�g�A�b�v
    /// </summary>
    public static void Setup()
    {
        Scene = SceneManager.GetActiveScene();
        LogController.Log($"{SceneName} was setuped.",LogTag.Scene);
    }

    /// <summary>
    /// ���݂̃V�[��
    /// </summary>
    public static Scene Scene { get; private set; }

    /// <summary>
    /// �V�[���ԍ�
    /// </summary>
    public static int SceneIndex => Scene.buildIndex;

    /// <summary>
    /// �V�[����
    /// </summary>
    public static string SceneName => Scene.name;

    /// <summary>
    /// �V�[�����L����
    /// </summary>
    public static bool SceneIsValid => Scene.IsValid();
}
