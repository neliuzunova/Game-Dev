using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))//other.gameObject.CompareTag("Player"))
        {
            print("oh no");
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);
        }
    }
}
