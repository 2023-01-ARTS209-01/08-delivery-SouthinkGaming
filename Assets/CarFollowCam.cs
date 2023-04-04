using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFollowCam : MonoBehaviour {
    [SerializeField] GameObject player;
    private Vector3 offset = new Vector3(0,0,-10f);

    // Update is called once per frame
    void Update(){
        transform.posistion = player.transform.posistion + offset;
    }
}