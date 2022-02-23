using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipShoot : MonoBehaviour
{
    int timer = 0;
    public GameObject HoldShine;
    public GameObject SuperBullet;
    public GameObject bullet;
    public Transform spawnpoint;
    float timeSpace = 0;
    float timeDown = 0;
    //Vector2 spawn_pos = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        HoldShine.SetActive(false);
    }
    
      

    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timeDown = Time.time;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
          
            timeSpace = Time.time;
        }
        if (Time.time-timeDown>1)
        {
            HoldShine.SetActive(true);
        }
        float result = timeSpace - timeDown;
        if(result > 1)
        {
           
            print(result);
            Instantiate(SuperBullet, spawnpoint.position + new Vector3(0, 1, 0), Quaternion.identity);
            timeSpace = 0;
            timeDown = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Space)&&timer >60)
        {
            HoldShine.SetActive(false);
            Instantiate(bullet, spawnpoint.position + new Vector3(0, 1, 0), Quaternion.identity);
            timer = 0;
        }
       
        timer++;
    }
   
}
