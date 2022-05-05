using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer RandomSpriteRenderer;
    public Sprite[] sprites;
    void Start()
    {
        RandomSpriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];
    }


}
