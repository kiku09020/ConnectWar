using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class SceneController : MonoBehaviour
{
    static int sceneCount;

    //-------------------------------------------

    private void Awake()
    {
        // �V�[���ǂݍ��݊������̃C�x���g�ǉ�
        SceneManager.sceneLoaded += SceneLoaded;

        SceneInfoSetup();
    }

    // �V�[���ǂݍ��݊������ɌĂяo�����
    void SceneLoaded(Scene scene, LoadSceneMode sceneMode)
    {
        NowScene.Setup();
    }

    // �V�[�����̃Z�b�g�A�b�v
    void SceneInfoSetup()
    {
        sceneCount = SceneManager.sceneCount;
    }

    //-------------------------------------------
    /// <summary>
    /// ���݂̃V�[����ǂݍ���
    /// </summary>
    public static void LoadNowScene()
    {
        SceneManager.LoadScene(NowScene.SceneIndex);
    }

    /// <summary>
    /// ���̃V�[����ǂݍ���
    /// </summary>
    public static void LoadNextScene()
    {
        var index = NowScene.SceneIndex + 1;

        // �ǂݍ���
        if (index < sceneCount) {
            SceneManager.LoadScene(index);
        }

        // �x��
        else {
            Debug.LogWarning("���̃V�[���͑��݂��܂���B");
        }
    }

    /// <summary>
    /// �O�̃V�[����ǂݍ���
    /// </summary>
    public static void LoadPrevScene()
    {
        var index = NowScene.SceneIndex - 1;

        // �ǂݍ���
        if (index > 0) {
            SceneManager.LoadScene(index);
        }

        // �x��
        else {
            Debug.LogWarning("�O�̃V�[���͑��݂��܂���B");
        }
    }

    //-------------------------------------------

    /// <summary>
    /// �V�[���ԍ��w��œǂݍ���
    /// </summary>
    public static void LoadScene(int index)
    {
        // �ǂݍ���
        if (index > 0 && index < sceneCount) {
            SceneManager.LoadScene(index);
        }

        // �x��
        else {
            Debug.LogWarning("�w�肳�ꂽ�V�[���ԍ��̃V�[���͑��݂��܂���B");
        }
    }

    /// <summary>
    /// �V�[�����w��œǂݍ���
    /// </summary>
    public static void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
