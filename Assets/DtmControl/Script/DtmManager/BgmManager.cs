using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : DtmManager
{
    [SerializeField] private List<AudioSource> Bgms = new List<AudioSource>();�@//BGM�̎�ނ܂ŕK�v

    public static BgmManager instance;�@//�@�V���O���g���Ƃ����������炵��

    

    protected override void SetUp()
    {
        if (instance == null)
        {
            instance = this;
        }
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
        //�Y���̋ȈȊO�͎~�߂�
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
            //���łɗ���Ă���̂ŉ������Ȃ�
        }
        else 
        {
            //�Ȃ𗬂�
            Bgms[num].Play();
        }
        
    }

}
