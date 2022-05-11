using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeIndixe : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource music;
    float FuelScaleX=0;
    float FuelScaleY = 0;
    float FuelIndex = 0;
    void Start()
    {
        FuelScaleX = transform.localScale.x;
        FuelScaleY = transform.localScale.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        FuelIndex =   music.time/(music.clip.length-10);
        transform.localScale = new Vector3(FuelScaleX, FuelScaleY *(1-FuelIndex), 1);
       
    }
}
