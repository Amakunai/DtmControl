using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeManager : DtmManager
{
    private AudioSource se;

    public static SeManager instance;

    public static float volume = 0.7f;//ウドネスを考慮していないボリューム　と　初期値

    [SerializeField] private List<AudioClip> clips = new List<AudioClip>();　//流すSE


    protected override void SetUp()
    {
        if (instance == null)
        {
            instance = this;
        }

        se = GetComponent<AudioSource>();
    }

    public override void SetVolume(float vol)
    {
        volume = vol;

        SetVolume();
    }

    public override void SetVolume()
    {
        se.volume = CalcVolume.CalcGetVolume(volume);
    }

    public void PlayOneShot(int num) //指定されたSEを再生する
    {
        se.PlayOneShot(clips[num]);
    }
}
