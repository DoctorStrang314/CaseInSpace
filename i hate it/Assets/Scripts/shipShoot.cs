using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipShoot : MonoBehaviour
{
    
    public GameObject HoldShine;
    public GameObject SuperBullet;
    public GameObject bullet;
    public Transform spawnpoint;
    int timer = 0;
    int superShoot = 5;
    float timeUp = 0;
    float timeDown = 0;
    bool hold;

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
            hold = true;
            timeDown = Time.time;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            hold = false;
            timeUp = Time.time;
        }

        if (Time.time-timeDown>1&&hold==true)//нужно для того что бы Time.time не нарушал условие через секунду не зависимо от того была нажата клавиша или нет
        {
            HoldShine.SetActive(true);
        }

        float result = timeUp - timeDown;
        if(result > 1 && superShoot>0)
        {
            HoldShine.SetActive(false);
            print(result);
            Instantiate(SuperBullet, spawnpoint.position + new Vector3(0, 1, 0), Quaternion.identity);
            timeUp = 0;
            timeDown = 0;
            superShoot--;
        }
        else if (Input.GetKeyDown(KeyCode.Space)&&timer >45)
        {
            Instantiate(bullet, spawnpoint.position + new Vector3(0, 1, 0), Quaternion.identity);
            timer = 0;
        }
       
        timer++;
        HoldShine.transform.position= gameObject.transform.position+new Vector3(0,0,1);
    }
   
}
