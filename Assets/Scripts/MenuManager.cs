using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public int sceneToLoad;
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
