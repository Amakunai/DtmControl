using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //scene遷移するだけ
    public const string A = "DtmTestSceneA";
    public const string B = "DtmTestSceneB";


    public void SceneLoad(string name) 
    {
        SceneManager.LoadScene(name);
    }
}
