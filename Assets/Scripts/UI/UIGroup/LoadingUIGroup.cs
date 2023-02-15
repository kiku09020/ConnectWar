using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingUIGroup : UIGroupBase
{
    [SerializeField] Image loadingImage;        // �i���o�[

    public override void Initialize()
    {
        if (loadingImage){
            loadingImage.fillAmount = 0;
        }
    }

    public void Loading(AsyncOperation async)
    {
        loadingImage.fillAmount = async.progress;
    }
}
