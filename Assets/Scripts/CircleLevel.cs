using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CircleLevel : MonoBehaviour
{
    public TMP_Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        var level = SceneManager.GetActiveScene().name;
        var tempTxt = level.Substring(5, 1);
        levelText.SetText(tempTxt);
    }
}
