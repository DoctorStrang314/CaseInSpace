using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipShoot : MonoBehaviour
{
    public int timer = 0;
    public GameObject bullet;
    public Transform spawnpoint;
    //Vector2 spawn_pos = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&&timer>60)
        {
            timer = 0;
            Instantiate(bullet, spawnpoint.position+ new Vector3(0,1,0), Quaternion.identity);
           
        }
      
        timer++;
    }
}
