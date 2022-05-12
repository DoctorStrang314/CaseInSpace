using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipShoot : MonoBehaviour
{
    
    public GameObject HoldShine;
    public GameObject SuperBullet;
    public GameObject bullet;
    public GameObject EnergyBar;
    public Transform spawnpoint;
    public AudioSource shoot;
    int timer = 0;
    
    float timeUp = 0;
    float timeDown = 0;
    float energy = 1f;
    bool hold;
    float EnergyScaleX = 0;
    float EnergyScaleY = 0;
    float result = 0;

    //Vector2 spawn_pos = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        HoldShine.SetActive(false);
        EnergyScaleX = EnergyBar.transform.localScale.x;
        EnergyScaleY = EnergyBar.transform.localScale.y;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale!=0) {
        
                EnergyBar.transform.localScale = new Vector3(EnergyScaleX, EnergyScaleY * energy, 1);
                if (Input.GetKeyDown(SetKey.Keys["PowerShoot"]))
                {
                    hold = true;
                    timeDown = Time.time;
                }

                if (Input.GetKeyUp(SetKey.Keys["PowerShoot"]))
                {
                    hold = false;
                    timeUp = Time.time;
                }

                if (Time.time-timeDown>0.7 && hold==true && energy>0.6)//нужно для того что бы Time.time не нарушал условие через секунду не зависимо от того была нажата клавиша или нет
                {
                    HoldShine.SetActive(true);
                }

                if (HoldShine.active==true)
                {
                    result = timeUp - timeDown;
                }

                if (result < 0.7)//решает проблему одиночного нжатия ПКМ,если не обнулить то обычные выстрелы не работают
                {
                    result = 0;
                }

                print(result);
               //Супер Выстрел
                if(result > 0.7  && energy > 0.6)
                {
                    HoldShine.SetActive(false);
                    Instantiate(SuperBullet, spawnpoint.position + new Vector3(0, 1, 0), Quaternion.identity);
                    timeUp = 0;
                    timeDown = 0;
                    timer = 0;
                    energy -= 0.6f;
                    result = 0;
                }

                //Обычный выстрел
                else if (Input.GetKeyDown(SetKey.Keys["Shoot"])&&timer >20 && energy>0.3)
                {
                    shoot.Play();   
                    Instantiate(bullet, spawnpoint.position + new Vector3(0, 1, 0), Quaternion.identity);
                    timer = 0;
                    energy -= 0.3f;
            
                }
                if (energy<1)
                {
                    energy += 0.003f;
                }
                timer++;
        
            }
        }
   
}
