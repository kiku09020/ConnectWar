using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSingleton<T> : MonoBehaviour where T : Component {
	static T instance;

	public static T Instance {
		get {
			if (!instance) {
				// 既存のインスタンス検索
				instance = FindObjectOfType<T>();

				// 無ければ新規作成
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

	// 新規作成
	static void SetupInstance()
	{
		var obj = new GameObject();
		obj.name = typeof(T).Name;

		instance = obj.AddComponent<T>();
	}

	// インスタンスの重複削除
	void RemoveDuplicates()
	{
		if (instance) {
			Destroy(gameObject);	// 既存であれば、自身を削除
		}
	}
}
