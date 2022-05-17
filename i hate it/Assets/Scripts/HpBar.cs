using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bar;
    float barScaleX = 0;
    float barScaleY = 0;
    float maxhp;
    void Start()
    {
        maxhp = TookDamedge.hpBoss;
        barScaleX = Bar.transform.localScale.x;
        barScaleY = Bar.transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (TookDamedge.hpBoss / maxhp < 0)
        {
            barScaleY = 0;//нужно для того чтобы разбер хп бара не выходил в - и тем самым не вылезал немного вперед после этого
        }
        Bar.transform.localScale = new Vector3(barScaleX, barScaleY * (TookDamedge.hpBoss/maxhp), 1);
        
    }
}
