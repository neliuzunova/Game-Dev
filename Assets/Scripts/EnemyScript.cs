using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spawnPoint;//Add empty gameobject as spawnPoint
    public GameObject player;//Add your player

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            player.transform.position = spawnPoint.position;
        }
    }
}
