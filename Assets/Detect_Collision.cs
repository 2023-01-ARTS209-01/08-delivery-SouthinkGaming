using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Collision : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("We hit something! ... It was " + collision.gameObject.name);
    }
    private void OnTriggerEnter2D(Collider2D trigger){
        Debug.Log("LERRRRROOOIIIIEEE JANNNKKEINS!!!!!!" + trigger.gameObject.name);
    }
}