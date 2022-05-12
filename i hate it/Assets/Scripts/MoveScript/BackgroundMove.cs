using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer _sprite;
    public int speed = 2;
    public float MinBack;
    
    Vector2 ResPos;
    
    void awake ()
    {
        ResPos = transform.position;
        MinBack = _sprite.bounds.size.y * 2 - ResPos.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.down*speed*Time.deltaTime);
        if (transform.position.y <= MinBack)
        {
            transform.position = ResPos;
        }
    }
}
