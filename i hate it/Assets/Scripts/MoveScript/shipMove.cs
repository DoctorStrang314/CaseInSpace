using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMove : MonoBehaviour
{
    float timer = 0.3f;
    float timeLeft = 0;
    bool swapMove = false;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        anim.GetComponent<Animator>();
    }
    public void right()
        {

        }
    // Update is called once per frame
   
    void Update()
    {   
        
        if (swapMove == false)
        {
             
            anim.SetBool("Left", Input.GetKey(KeyCode.A));
          
            if (Input.GetKey(KeyCode.D) && timer > 0.3 && transform.position.x < 1)
            {
                //anim.SetTrigger("Right");
                transform.Translate(new Vector3(1, 0, 0));
                
                timer -= 0.3f;
            }
            else if (Input.GetKey(KeyCode.A) && timer > 0.3 && transform.position.x > -0.4)
            {
                
                transform.Translate(new Vector3(-1, 0, 0));
                timer -= 0.3f;
            }
            else if (Input.GetKey(KeyCode.W) && timer > 0.23 && transform.position.y < -3)
            {
                transform.Translate(new Vector3(0, 1, 0));
                timer -= 0.23f;
            }
            else if (Input.GetKey(KeyCode.S) && timer > 0.23 && transform.position.y > -4.4)
            {
                transform.Translate(new Vector3(0, -1, 0));
                timer -= 0.23f;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.A) && timer > 0.3 && transform.position.x < 0.9)
            {
                transform.Translate(new Vector3(1, 0, 0));
                timer -= 0.3f;
            }
            else if (Input.GetKey(KeyCode.D) && timer > 0.3 && transform.position.x > -0.4)
            {
                transform.Translate(new Vector3(-1, 0, 0));
                timer -= 0.3f;
            }
            else if (Input.GetKey(KeyCode.S) && timer > 0.23 && transform.position.y < -2.6)
            {
                transform.Translate(new Vector3(0, 1, 0));
                timer -= 0.23f;
            }
            else if (Input.GetKey(KeyCode.W) && timer > 0.23 && transform.position.y > -4.4)
            {
                transform.Translate(new Vector3(0, -1, 0));
                timer -= 0.23f;
            }
        }

        if (timer < 0.3)
        {
        timer += Time.deltaTime;
        }
        timeLeft += Time.deltaTime;
        if (timeLeft > 3)
        {
            swapMove = false;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }

       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fog")
        {
            swapMove = true;
            timeLeft = 0;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.64f, 0f, 1f);
        }

    }
    
        
        
  
}
 