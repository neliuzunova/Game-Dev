using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectScript : MonoBehaviour{
    public Texture img;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col){
        Destroy(gameObject);
        print("Got a key");
    }
}
