using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.IO;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class LoadNumberLevel : MonoBehaviour
{
    public GameObject sceneElement;
    Scene[] scenes;
    string LevelKey = "Level";
    int levelTextIndex = 1;
    // Start is called before the first frame update
    void Start()
    {
        var numberScene = SceneManager.sceneCountInBuildSettings;
        List<string> arrayName = new List<string>();
        for (int n = 0; n < numberScene; n++)
        {
            var temp = Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(n));
            var checkname = temp.IndexOf(LevelKey);
            if (checkname == 0) {
                arrayName.Add(temp);
            }
        }
        for (int i = 0; i < arrayName.Count; i++) {
            int l_key = LevelKey.Length;
            string level = arrayName[i].Substring(l_key, 1);

            var sceneBoard = Instantiate(sceneElement, transform.position, Quaternion.identity);
            sceneBoard.transform.SetParent(this.transform);

            int copyIndex = i;
            sceneBoard.GetComponent<Button>().onClick.AddListener(() => {
                SceneManager.LoadScene("Level" + int.Parse(level));
            });

            GameObject levelTextElement = sceneBoard.transform.GetChild(levelTextIndex).gameObject;
            var elementText = levelTextElement.GetComponent<TextMeshProUGUI>();

            elementText.SetText(level);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
