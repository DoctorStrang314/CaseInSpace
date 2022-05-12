using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public AudioSource music;
    
    public void Update()
    {
        
        if (Input.GetKeyDown(SetKey.Keys["Pause"]))
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            music.Pause();
        }
        else if (Input.GetKey(KeyCode.Space)&& panel.active==true)
        {
     
            panel.SetActive(false);
            Time.timeScale = 1f;
            music.Play();
        }

       
    }
}
