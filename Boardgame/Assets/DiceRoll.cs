using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public Sprite[] numbers;

    private SpriteRenderer sprtRend;

    private void Start()
    {
        sprtRend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int randNumb = Random.Range(0, 5);
            sprtRend.sprite = numbers[randNumb];
        }
    }
}
