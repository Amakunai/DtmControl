using UnityEngine;

public static class CalcVolume 
{
    public static float CalcGetVolume(float volLvRatio) //0~1の数字をウドネスを考慮したボリュームにする。
    {
        if (volLvRatio <= 0.0f)
        {
            return 0.0f;
        }
        else if (volLvRatio >= 1.0f)
        {
            return 1.0f;
        }
        else
        {
            return Mathf.Pow(10.0f, -Mathf.Log(1.0f / volLvRatio, 2.0f) / 2.0f);
        }
    }
}
