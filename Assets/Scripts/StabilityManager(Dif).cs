using System;
using System.Linq;
using UnityEngine;

public class StabilityManagerDif : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private int destability;
    [SerializeField, Range(1, 2)] private int playerID;

    [SerializeField] static Sprite[] sprites;

    [SerializeField] private int length = sprites.Length;
    

    [System.Serializable]
    public class IntArray
    {
        public int[] intArrayLow = new int[2];     //������� ��� ����� �� �������, ��� ��������� �������� ������ �� unity
    }
    public IntArray[] intArrayHigh = new IntArray[9];

     

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("StabilColl");
            destability++;
        }

        if (Enumerable.Range(1, 5).Contains(destability)) //�������� ���� �� ���� destability � Range
        {
            spriteRenderer.sprite = sprites[1];
        }

        for (int i = 0; i < length; i++)
        {

        }

    }


}

