using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{
  private Rigidbody2D myRigidbody2D;  
   
    // Start is called before the first frame update
    void Start()

    {
        myRigidbody2D = GetComponet<myRigidbody2D>;
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerStay2D(Collider2D);


    }
}
