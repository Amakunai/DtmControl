using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeManager : DtmManager
{
    private AudioSource se;

    public static SeManager instance;

    public static float volume = 0.7f;//�E�h�l�X���l�����Ă��Ȃ��{�����[���@�Ɓ@�����l

    [SerializeField] private List<AudioClip> clips = new List<AudioClip>();�@//����SE


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

    public void PlayOneShot(int num) //�w�肳�ꂽSE���Đ�����
    {
        se.PlayOneShot(clips[num]);
    }
}
