using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class DtmSlider : MonoBehaviour
{
    protected Slider slider;　

    protected DtmManager dtm;

    protected void Start() 
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { ChangeValue(); });

        SetUp();
    }

    protected abstract void SetUp();　//Startのときに呼び出す　dtmにインスタンスを入れ、スライダーの数値を合わせる
  

    protected virtual void ChangeValue()　//数値が変更されたとき、音量を変更する
    {
        dtm.SetVolume(slider.value);
    }
}
