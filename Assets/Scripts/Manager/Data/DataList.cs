using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�f�[�^�C���^�[�t�F�[�X
public interface IData { }

/// <summary>
/// �Z�[�u�f�[�^
/// </summary>
[System.Serializable]
public class SaveData : IData {

}

/// <summary>
/// �ݒ�f�[�^
/// </summary>
[System.Serializable]
public class SettingData : IData { 
    public bool isValidBGM;     // BGM�̗L��/����
    public bool isValidSE;      // SE�̗L��/����
}

