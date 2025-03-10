using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void sceneSwitch(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
