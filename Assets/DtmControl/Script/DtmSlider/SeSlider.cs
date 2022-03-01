using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SeSlider : DtmSlider,  IPointerUpHandler
{
    protected override void SetUp()
    {
        dtm = SeManager.instance;

        slider.value = SeManager.instance.volume;
    }

    public void OnPointerUp(PointerEventData data)
    {
        SeManager.instance.PlayOneShot(SeName.click);
    }
}