using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& gameObject.active==true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void ExitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }
}
