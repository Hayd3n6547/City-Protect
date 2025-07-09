using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleLeftRight : MonoBehaviour
{
    // This is the number that limits how far to the right.
    [Tooltip("This number is limits how far to the right")]
    [SerializeField] public float RightLimit = 5.5f;
    // This is the number that limits how far to the left.
    [Tooltip("This number is limits how far to the left")]
    [SerializeField] public float LeftLimit = -5.5f;
    // This is the key bind for left movement
    [Tooltip(" key bind for left movement")]
    [SerializeField] public KeyCode LeftMove = KeyCode.A;
    // This is the key bind for right movement
    [Tooltip("key bind for right movement")]
    [SerializeField] public KeyCode RightMove = KeyCode.D;
    //This is the speed for the left movement it must be negitive
    [Tooltip("speed for left movement it must be negitive")]
    [SerializeField] public float LeftSpeed = -10;
    //This is the speed for left movement it must be positive
    [Tooltip("speed for left movement it must be positive")]
    [SerializeField] public float RightSpeed = 10;


    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input for Left this moves the paddle left.
        if (Input.GetKey(LeftMove) && transform.position.x < LeftLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(LeftSpeed, 0);
            Debug.Log("You pushed right!");
        }
        //Input for Right this moves the paddle Right.
        else if (Input.GetKey(RightMove) && transform.position.x > RightLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(RightSpeed, 0);

        }
        else
        {
            //This is used to stop the player
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
