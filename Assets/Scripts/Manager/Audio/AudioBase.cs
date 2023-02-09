using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AudioBase<T> : Singleton<T> where T: AudioBase<T>
{
	/// <summary>
	/// Resources�̃t�@�C���p�X
	/// </summary>
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
	/// AudioSource�̃Z�b�g�A�b�v
	/// </summary>
	protected virtual void Setup()
    {
		source = gameObject.AddComponent<AudioSource>();
		source.playOnAwake = false;
    }

	// �����t�@�C�����擾���āADictionary�Ɋi�[
	void GetAudioFiles()
	{
		object[] list = Resources.LoadAll(FilePath);

		foreach (AudioClip clip in list) {
			dict[clip.name] = clip;
		}
	}

	//-------------------------------------------

	/// <summary>
	/// �����̍Đ�
	/// </summary>
	public virtual void Play(string audioName, float delay = 0, float volume = 1, float pitch = 1)
	{
		// �w�肳�ꂽ�����t�@�C���������݂��Ȃ��ꍇ
        if (!dict.ContainsKey(audioName)) {
			LogController.ColoredLog("�w�肳�ꂽ�����͑��݂��܂���B", Color.red);
			return;
        }

		// �����Đ�
        else {
			StartCoroutine(PlayBase(audioName, delay, volume, pitch));
        }
	}

	// delay�p�R���[�`��
	IEnumerator PlayBase(string audioName,float delay=0,float volume=1,float pitch = 1)
    {
		// �ҋ@
		yield return new WaitForSecondsRealtime(delay);

		// �ݒ�
		source.volume = volume;
		source.pitch = pitch;

		// �Đ�
		var clip = dict[audioName];
		source.clip = clip;
		source.PlayOneShot(clip);
    }

	//-------------------------------------------

	/// <summary>
	/// �ꎞ��~
	/// </summary>
	public void Pause()
    {
		source.Pause();
    }

	/// <summary>
	///  �ꎞ��~����
	/// </summary>
	public void UnPause()
    {
		source.UnPause();
    }

	/// <summary>
	/// �~���[�g
	/// </summary>
	public void Mute()
    {
		source.mute = true;
    }
	/// <summary>
	/// �~���[�g����
	/// </summary>
	public void UnMute()
    {
		source.mute = false;
    }

	/// <summary>
	/// ��~
	/// </summary>
	public void Stop()
    {
		source.Stop();
    }

	/// <summary>
	/// 
	/// </summary>
	public void ChangeVolume(float volume)
    {
		source.volume = volume;
    }

	/// <summary>
	/// �s�b�`�ύX
	/// </summary>
	public void ChangePitch(float pitch)
    {
		source.pitch = pitch;
    }
}
