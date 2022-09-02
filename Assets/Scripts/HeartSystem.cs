using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life = 3;
    public Sprite EmptyHeart;
    public GameObject RedSquare;

    void Start()
    {

        //tova reshenie e disguting no raboti
        //sujalqvam

        RedSquare.transform.position = new Vector3(5000, 5000, 0);
    }

    void Update()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
        }else if (life < 2)
        {
            RedSquare.transform.position = new Vector3(0, 0, 0);
            Destroy(hearts[1].gameObject);

        }
        else if(life <3)
        {
            Destroy(hearts[2].gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            life--;
        }
    }
}
