using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : DtmManager
{
    [SerializeField] private List<AudioSource> Bgms = new List<AudioSource>();　//BGMの種類まで必要

    public static BgmManager instance;　//　シングルトンとかいうやり方らしい

    public　static float volume = 0.7f;//ウドネスを考慮していないボリューム　と　初期値

    protected override void SetUp()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public override void SetVolume(float vol)
    {
        volume = vol;

        SetVolume();
    }

    public override void SetVolume()
    {
        foreach (AudioSource audio in Bgms)
        {
            audio.volume = CalcVolume.CalcGetVolume(volume);
        }
    }

    public void SetBgm(int num) 
    {
        //該当の曲以外は止める
        int i = 0;
        foreach (AudioSource source in Bgms) 
        {
            if (i != num) 
            {
                source.Stop();
            }
            i++;
        }

        if (Bgms[num].isPlaying)
        {
            //すでに流れているので何もしない
        }
        else 
        {
            //曲を流す
            Bgms[num].Play();
        }
        
    }

}
