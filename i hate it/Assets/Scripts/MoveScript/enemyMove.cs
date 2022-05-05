using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public float angle = 0;
    public float rotationSpeed=0;
    bool rot = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(new Vector3(0, -4, 0) * Time.deltaTime);
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < 5.5 && rot==false)
        {
            transform.Rotate(new Vector3(0, 0, angle));
            rot = true;
        }
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SuperBullet" )
        {
            Destroy(gameObject);
        }
    }
}
