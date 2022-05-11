using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject ChooseLVL;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& ChooseLVL.active==true)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene("Menu_scen");
        
    }
}
