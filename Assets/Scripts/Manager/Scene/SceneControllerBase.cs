using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public abstract class SceneControllerBase<T> : Singleton<T> where T:SceneControllerBase<T>
{
    protected static int sceneCount;

    protected override void Awake()
    {
        // �C�x���g�ǉ�
        SceneManager.sceneLoaded += SceneLoaded;
        sceneCount = SceneManager.sceneCountInBuildSettings;
    }

    // �ǂݍ��݊������̏���
    static void SceneLoaded(Scene scene,LoadSceneMode sceneMode)
    {
        NowScene.Setup();

        /* �����ɏ�����ǉ� */
        
    }

    /// <summary>
    /// ���̃V�[���̓ǂݍ��݃`�F�b�N
    /// </summary>
    /// <param name="loadAction">���[�h����</param>
    protected static void NextSceneLoadCheck(Action loadAction)
    {
        var index = NowScene.SceneIndex + 1;

        if (index < sceneCount) {
            loadAction();
        }

        else {
            Debug.LogWarning("���̃V�[���͑��݂��܂���B");
        }
    }

    /// <summary>
    /// �O�̃V�[���̓ǂݍ��݃`�F�b�N
    /// </summary>
    /// <param name="loadAction">���[�h����</param>
    protected static void PrevSceneLoadCheck(Action loadAction)
    {
        var index = NowScene.SceneIndex - 1;

        if (0 <= index) {
            loadAction();
        }

        else {
            Debug.LogWarning("�O�̃V�[���͑��݂��܂���B");
        }
    }
}
