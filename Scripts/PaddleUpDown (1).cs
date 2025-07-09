using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleUpDown : MonoBehaviour
{
    // This is the number that limits how far to the Up.
    [Tooltip("This number is limits how far to the Up. Note might need to tinker with this one to get limit right. Keep negitive.")]
    [SerializeField] public float UpLimit = 5.5f;
    // This is the number that limits how far to the Down.
    [Tooltip("This number is limits how far to the Down. Note might need to tinker with this one to get limit right.")]
    [SerializeField] public float DownLimit = -5.5f;
    // This is the key bind for up movement
    [Tooltip(" key bind for up movement")]
    [SerializeField] public KeyCode UpMove = KeyCode.W;
    // This is the key bind for down movement
    [Tooltip("key bind for down movement")]
    [SerializeField] public KeyCode DownMove = KeyCode.S;
    //This is the speed for the left movement it must be positive
    [Tooltip("speed for up movement it must be positive")]
    [SerializeField] public float UpSpeed = 10;
    //This is the speed for left movement it must be Negative
    [Tooltip("speed for down movement it must be Negative")]
    [SerializeField] public float DownSpeed = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This makes the paddle go up
          if (Input.GetKey(UpMove) && transform.position.y < UpLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, UpSpeed);
        }
          //This makes the paddle go down
        else if (Input.GetKey(DownMove) && transform.position.y > DownLimit)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, DownSpeed);
        }
        else
        {
            //This is used to stop the player
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
