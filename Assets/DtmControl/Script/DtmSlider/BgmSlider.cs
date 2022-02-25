using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmSlider : DtmSlider
{
    protected override void SetUp()
    {
        dtm = BgmManager.instance;

        slider.value = BgmManager.volume;
    }
}