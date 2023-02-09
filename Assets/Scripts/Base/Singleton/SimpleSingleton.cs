using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSingleton<T> : MonoBehaviour where T : Component {
	static T instance;

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

	protected virtual void Awake()
	{
		RemoveDuplicates();
	}

	// �V�K�쐬
	static void SetupInstance()
	{
		var obj = new GameObject();
		obj.name = typeof(T).Name;

		instance = obj.AddComponent<T>();
	}

	// �C���X�^���X�̏d���폜
	void RemoveDuplicates()
	{
		if (instance) {
			Destroy(gameObject);	// �����ł���΁A���g���폜
		}
	}
}
