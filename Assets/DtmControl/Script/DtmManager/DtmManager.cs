using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DtmManager : MonoBehaviour
{
    private void Awake()
    {
        SetUp();//instance�̐ݒ�

        SetVolume();�@//�{�����[���̐ݒ�
    }

    protected abstract void SetUp();�@//instance�̐ݒ�

    public abstract void SetVolume(float vol);�@//�@���ʂ̕ύX�@�{�@AudioSource�ɐݒ�

    public abstract void SetVolume();//�E�h�l�X���l��������AudioSource�ɐݒ肷��

}
