using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
       
        myRigidbody2D = GetComponent<Rigidbody2D>;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
