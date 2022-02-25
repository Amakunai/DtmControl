using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class DtmSlider : MonoBehaviour
{
    protected Slider slider;�@

    protected DtmManager dtm;

    protected void Start() 
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { ChangeValue(); });

        SetUp();
    }

    protected abstract void SetUp();�@//Start�̂Ƃ��ɌĂяo���@dtm�ɃC���X�^���X�����A�X���C�_�[�̐��l�����킹��
  

    protected virtual void ChangeValue()�@//���l���ύX���ꂽ�Ƃ��A���ʂ�ύX����
    {
        dtm.SetVolume(slider.value);
    }
}
