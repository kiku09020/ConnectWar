using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExtendInput : MonoBehaviour {
    // �}�E�X�v���p�e�B
    static Mouse Mouse => GetMouse();

    // �}�E�X�擾
    static Mouse GetMouse()
    {
        var mouse = Mouse.current;

        if (mouse != null) {
            return mouse;
        }

        return null;
    }

    //-------------------------------------------

    /// <summary>
    /// �}�E�X�̍��W�����[���h���W�Ƃ��Ď擾
    /// </summary>
    /// <returns>�}�E�X�̃��[���h���W</returns>
    public static Vector2 GetMousePosition_World()
    {
        var mousePos = Mouse.position.ReadValue();
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    /// <summary>
    /// �}�E�X�̍��W�����[���h���W�Ƃ��Ď擾
    /// </summary>
    /// <param name="camera">�ڕW�̃J����</param>
    /// <returns>�}�E�X�̃��[���h���W</returns>
    public static Vector2 GetMousePosition_World(Camera camera)
    {
        if (camera) {
            var mousePos = Mouse.position.ReadValue();
            return camera.ScreenToWorldPoint(mousePos);
        }

        throw new System.Exception($"{camera} doesn't exist.");
    }

    //-------------------------------------------



}
