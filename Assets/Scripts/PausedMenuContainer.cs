using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenuContainer : MonoBehaviour
{
    public string _mainMenuLevel;
    private string levelToLoad;

    public void ChangeLevel()
    {
        SceneManager.LoadScene(_mainMenuLevel);
        //levelToLoad = PlayerPrefs.GetString("SavedLevel");
        //SceneManager.LoadScene(levelToLoad);
    }
}
