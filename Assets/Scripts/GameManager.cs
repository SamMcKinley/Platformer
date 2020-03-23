using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int currentScene = 0;

    void Awake()
    {

        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(this.gameObject);
                Debug.Log("Warning: A second gamemanager was detected and destroyed");
            }

        } 
    }
    public void LoadLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
        //Potentially dangerous
        currentScene++;
    }


    public void LoadLevel(int indexToLoad)
    {
        SceneManager.LoadScene(indexToLoad);
        currentScene = indexToLoad;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }
}
 
