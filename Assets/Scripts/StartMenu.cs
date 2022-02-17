using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    public void LoadWithoutAI()
    {
        SceneManager.LoadScene("Without AI");
        // main merge test
        // main merge test
    }

    public void LoadWithAI()
    {
        SceneManager.LoadScene("With AI");
    }
}




