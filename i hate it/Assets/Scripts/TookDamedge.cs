using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TookDamedge : MonoBehaviour
{
    // Start is called before the first frame update
    public string name;
    public string name2;
    public float hp;
    public static float hpBoss;
   
    void Start()
    {
        hpBoss = 250;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            
            if (gameObject.name =="ship") {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            { 
                Destroy(gameObject);
            }
        }
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.tag==name || collision.tag == name2)
        {
            hp = hp - 10;
            hpBoss = hpBoss - 10;
        }
      else if(collision.tag == "SuperBullet") 
        {
            hp = hp - 25;
            hpBoss = hpBoss - 25;
        }
    }
   
}
