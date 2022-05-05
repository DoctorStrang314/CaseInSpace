using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMove : MonoBehaviour
{
    int timer = 30;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && timer > 20 && transform.position.x < 0.9)
        {
            transform.Translate(new Vector3(1, 0, 0));
            timer = 0;
        }
        else if (Input.GetKey(KeyCode.A) && timer > 20 && transform.position.x > -0.4)
        {
            transform.Translate(new Vector3(-1, 0, 0));
            timer = 0;
        }
        else if (Input.GetKey(KeyCode.W) && timer > 20 && transform.position.y < -2.6)
        {
            transform.Translate(new Vector3(0, 1, 0));
            timer = 0;
        }
        else if (Input.GetKey(KeyCode.S) && timer > 20 && transform.position.y > -4.4)
        {
            transform.Translate(new Vector3(0, -1, 0));
            timer = 0;
        }

        timer++;
    }
}
