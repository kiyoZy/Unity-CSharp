using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D myRigitBody;
    
    public float speedX = 15;
    public float speedY = 15;


    // Start is called before the first frame update
    void Start()
    {
        myRigitBody = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 force = new Vector2(speedX, speedY);

        myRigitBody.AddForce(force);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
