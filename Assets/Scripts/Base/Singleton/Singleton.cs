using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : SimpleSingleton<T> where T:Singleton<T>
{
	protected virtual void Awake()
	{
		RemoveDuplicates();
	}

	// �C���X�^���X�̏d�����폜
	void RemoveDuplicates()
	{
		// �V�[����ɖ������
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
