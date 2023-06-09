using System;
using System.Linq;
using UnityEngine;

public class StabilityManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private int destability;

    [SerializeField] private Sprite[] sprites;
    int min = 0, max = 3, difference = 3, spriteInOrder = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            destability++;

            for (int i = 0; i < 8; i++)
            {

                if (Enumerable.Range(min, max).Contains(destability))
                {
                    Debug.Log($"min {min},max {max}, i {i}");
                    spriteRenderer.sprite = sprites[spriteInOrder];
                    min += difference;
                    max += difference;
                    spriteInOrder++;
                    break;
                }
            }
        }        
    }
}

