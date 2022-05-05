using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource music;
    void Start()
    {
        float musicPos = System.Math.Abs(transform.position.y) / 290;
        music.time = musicPos * music.clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -4, 0) * Time.deltaTime);
        if (Time.time> music.clip.length)
        {
            print(transform.position.y);
        }
       
    }
}
