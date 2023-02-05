using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSingleton<T> : MonoBehaviour where T : Component {
	protected static T instance;

	public static T Instance {
		get {
			if (!instance) {
				// �����̃C���X�^���X����
				instance = FindObjectOfType<T>();

				// ������ΐV�K�쐬
				if (!instance) {
					SetupInstance();
				}
			}

			return instance;
		}
	}

	// �V�K�쐬
	static void SetupInstance()
	{
		var obj = new GameObject();
		obj.name = typeof(T).Name;

		instance = obj.AddComponent<T>();
	}
}
