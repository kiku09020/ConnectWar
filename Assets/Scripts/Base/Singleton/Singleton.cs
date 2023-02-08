using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : SimpleSingleton<T> where T:Singleton<T>
{
	sealed protected override void RemoveDuplicates()
	{
		// �V�[����ɖ�����ΐV�K�쐬
		if (!instance) {
			instance = this as T;
			DontDestroyOnLoad(gameObject);
		}

		// ���ɂ���Ύ��g���폜
		else {
			Destroy(gameObject);
		}
	}
}
