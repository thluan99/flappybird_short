using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private GameManager() { }

    private void Awake()
    {
        var gameManager = GameObject.FindObjectOfType<GameManager>();
        if (!gameManager)
        {
            Instance = this;
        } else 
        {
            Instance = gameManager;
        }
        DontDestroyOnLoad(this);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
