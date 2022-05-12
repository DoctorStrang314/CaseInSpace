using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject panel;
    public GameObject Boss;
    public GameObject Ship;
    public GameObject ShipAnim;
    public GameObject enemys;
    bool flag = false;
    float finishTime = 0;
    float startTime = 0;
   
    void Update()
    {
        
        if (Boss == false && flag == false)
        {
            Ship.GetComponent<CapsuleCollider2D>().enabled = false;
            ShipAnim.GetComponent<Animator>().speed = 0.1f;
            finishTime = Time.time;
            flag = true;
        }



        if (flag)
        {
            if (Time.timeScale > 0.2)
            {
                Time.timeScale = (finishTime + 1) - Time.time;
            }
            else
            {
                Destroy(enemys);
                panel.SetActive(true);
                Time.timeScale = 5;
                flag = true;
            }

        }
    }
}
