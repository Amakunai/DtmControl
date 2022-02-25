using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DtmManager : MonoBehaviour
{
    private void Awake()
    {
        SetUp();//instanceの設定

        SetVolume();　//ボリュームの設定
    }

    protected abstract void SetUp();　//instanceの設定

    public abstract void SetVolume(float vol);　//　音量の変更　＋　AudioSourceに設定

    public abstract void SetVolume();//ウドネスを考慮したをAudioSourceに設定する

}
