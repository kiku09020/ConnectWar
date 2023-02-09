using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExtendInput : MonoBehaviour
{
    public class Mouse_ {
        static Mouse mouse = Mouse.current;

        /// <summary>
        /// �}�E�X�̍��W�����[���h���W�Ƃ��Ď擾
        /// </summary>
        /// <returns>�}�E�X�̃��[���h���W</returns>
        public static Vector2 GetMousePosition_World()
        {
            var mousePos = mouse.position.ReadValue();
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
                var mousePos = mouse.position.ReadValue();
                return camera.ScreenToWorldPoint(mousePos);
            }

            throw new System.Exception($"{camera} doesn't exist.");
        }
    }
}
