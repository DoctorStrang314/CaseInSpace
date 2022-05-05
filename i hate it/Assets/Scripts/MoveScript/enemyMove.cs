using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
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
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SuperBullet" )
        {
            Destroy(gameObject);
        }
    }
}
