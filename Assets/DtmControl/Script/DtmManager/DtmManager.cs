using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DtmManager : MonoBehaviour
{
    public float volume = 0.7f;//�E�h�l�X���l�����Ă��Ȃ��{�����[���@�Ɓ@�����l

    private void Awake()
    {
        SetUp();//instance�̐ݒ�

        SetVolume();�@//�{�����[���̐ݒ�
    }

    protected abstract void SetUp();�@//instance�̐ݒ�

    public void SetVolume(float vol) //�@���ʂ̕ύX�@�{�@AudioSource�ɐݒ�
    {
        volume = vol;

        SetVolume();

    }�@

    public abstract void SetVolume();//�E�h�l�X���l��������AudioSource�ɐݒ肷��

}
