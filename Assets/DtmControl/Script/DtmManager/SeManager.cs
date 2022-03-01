using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeManager : DtmManager
{
    private AudioSource se;

    public static SeManager instance;

    [SerializeField] private List<AudioClip> clips = new List<AudioClip>();Å@//ó¨Ç∑SE


    protected override void SetUp()
    {
        if (instance == null)
        {
            instance = this;
        }

        se = GetComponent<AudioSource>();
    }

    public override void SetVolume()
    {
        se.volume = CalcVolume.CalcGetVolume(volume);
    }

    public void PlayOneShot(int num) //éwíËÇ≥ÇÍÇΩSEÇçƒê∂Ç∑ÇÈ
    {
        se.PlayOneShot(clips[num]);
    }
}
