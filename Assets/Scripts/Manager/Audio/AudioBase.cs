using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AudioBase<T> : Singleton<T> where T: AudioBase<T>
{
	protected abstract string FilePath { get; }

	protected AudioSource source;
	protected Dictionary<string, AudioClip> dict = new Dictionary<string, AudioClip>();

	protected override void Awake()
	{
		base.Awake();

		Setup();
		GetAudioFiles();
	}

	/// <summary>
	/// �Z�b�g�A�b�v
	/// </summary>
	protected abstract void Setup();

	// �����t�@�C�����擾���āADictionary�Ɋi�[
	void GetAudioFiles()
	{
		object[] list = Resources.LoadAll(FilePath);

		foreach (AudioClip clip in list) {
			dict[clip.name] = clip;
		}
	}

	/// <summary>
	/// �����̍Đ�
	/// </summary>
	public virtual void Play(string audioName, float delay = 0, float volume = 1, float pitch = 1)
	{
        if (!dict.ContainsKey(audioName)) {
			
        }
	}
}
