using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float smoothTime = 10f;
    private Vector3 smoothVelocity = Vector3.zero;
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance<= 2)
        {
            
            transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
        }
        
    }
}
