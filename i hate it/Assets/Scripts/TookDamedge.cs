using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TookDamedge : MonoBehaviour
{
    // Start is called before the first frame update
    public string name;
    public int hp; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.tag==name)
        {
            hp = hp - 10;
        }
      else if(collision.tag == "SuperBullet") 
        {
            hp = hp - 100;

        }
    }
   
}
