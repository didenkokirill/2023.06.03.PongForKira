using System;
using System.Linq;
using UnityEngine;

public class StabilityManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite[] sprites;

    [SerializeField] private int destability;

    public int spriteInOrder = 1;
    public int conversion = 0, difference = 5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {  
            destability++;

            if (destability >= conversion)
            {
                spriteRenderer.sprite = sprites[spriteInOrder];
                spriteInOrder++;

                conversion += difference;
            }
        }        
    }
}

