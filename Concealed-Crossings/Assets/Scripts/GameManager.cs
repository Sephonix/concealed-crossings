using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        SceneManager.LoadSceneAsync((int)SceneIndexes.MAIN_MENU, LoadSceneMode.Additive);
    }

    public void LoadGame()
    {
        SceneManager.UnloadSceneAsync((int)SceneIndexes.MAIN_MENU);
        SceneManager.LoadSceneAsync((int)SceneIndexes.SCENE1, LoadSceneMode.Additive);
    }
}
