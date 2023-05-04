using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Scene 2");
    }

    public void ResumeGame()
    {
        SceneManager.LoadScene("Scene 1");
    }


    public void EndGame()
    {
        SceneManager.LoadScene("Scene 3");
    }

}
