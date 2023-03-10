using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigitBody;

    public float playerSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        myRigitBody = this.gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 force = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = new Vector2(playerSpeed * -1, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector2(playerSpeed, 0);
        }

        myRigitBody.MovePosition(myRigitBody.position + force * Time.fixedDeltaTime);
    }
}
