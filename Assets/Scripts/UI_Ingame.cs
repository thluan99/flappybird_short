using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI_Ingame : MonoBehaviour
{
    public GameObject retry;
    public GameObject nextLevel;
    int textIndexTitle = 1;
    const string COMPLETE = "Complete!";
    const string UNCOMPLETE = "Fail!";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame(bool complete) {
        Time.timeScale = 0f;
        var titleEndGame = transform.GetChild(textIndexTitle).gameObject.GetComponent<TextMeshProUGUI>();
        if (!complete) {
            titleEndGame.SetText(UNCOMPLETE);
            retry.SetActive(true);
            nextLevel.SetActive(false);
        } else {
            titleEndGame.SetText(COMPLETE);
            retry.SetActive(false);
            nextLevel.SetActive(true);
        }
    }

    public void ReplayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void BackToMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }

    public void LoadNextlevel() {
        Time.timeScale = 1f;
        int buildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(buildIndex + 1);
    }
}
