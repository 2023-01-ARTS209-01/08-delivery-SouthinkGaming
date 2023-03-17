using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Collision : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("We hit something! ... It was " + collision);
    }
}