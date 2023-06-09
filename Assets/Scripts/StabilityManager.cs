using System;
using System.Linq;
using UnityEngine;

public class StabilityManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite[] sprites;

    [SerializeField] private int destability;

    [Range(0, 8)] int spriteInOrder = 1;
    int min = 0, max = 5, difference = 5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            destability++;

            for (int i = 0; i < 8; i++)
            {
                if (Enumerable.Range(min, max).Contains(destability))
                {
                    spriteRenderer.sprite = sprites[spriteInOrder];
                    spriteInOrder++;

                    min += difference;
                    max += difference;

                    break;
                }
            }
        }        
    }
}

