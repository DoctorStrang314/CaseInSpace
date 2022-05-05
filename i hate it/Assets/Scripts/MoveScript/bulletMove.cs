using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    // Start is called before the first frame update

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 25, 0) * Time.deltaTime);

       

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="boss" || other.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
