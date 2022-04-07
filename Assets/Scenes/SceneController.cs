using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;


public class SceneController : MonoBehaviour
{
    public static string keyWord;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }


    public void GoNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void keyWordForGoogle(string keyWordName)
    {
        keyWord = keyWordName;
        Debug.Log(keyWord);
       // string url = "https://bit.ly/3LtN94b";
      

    }

    }

