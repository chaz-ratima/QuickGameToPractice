using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public string myScene = "";

    public void LoadNextScene()
    {
        SceneManager.LoadScene(myScene);
    }

    public void LoadInside()
    {
        SceneManager.LoadScene("InHouse");
    }

    public void LoadOutside()
    {
        SceneManager.LoadScene("OutsideHouse");
    }

    public void LoadFantasyWorld()
    {
        SceneManager.LoadScene("FantasyWorld");
    }
}
