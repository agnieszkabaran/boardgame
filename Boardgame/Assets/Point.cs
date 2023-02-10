using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        OnTriggerStay2D(Collider2D);
    }
}
