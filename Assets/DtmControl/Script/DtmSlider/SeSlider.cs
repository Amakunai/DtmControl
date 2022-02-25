using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeSlider : DtmSlider
{
    protected override void SetUp()
    {
        dtm = SeManager.instance;

        slider.value = SeManager.volume;
    }
}