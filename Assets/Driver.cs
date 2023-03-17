using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {
    // Controles the stearing speed of the car
    [SerializeField] float stearSpeed = 1f;
    // Controles the driving speed of the car
    [SerializeField] float driveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start() {}
    // Update is called once per frame
    void Update() {
        float steerAmount1 = Input.GetAxis("Horizontal") * stearSpeed;
        float steerAmount2 = Input.GetAxis("Vertical") * stearSpeed;

        transform.Rotate(0, 0, -stearSpeed);
        transform.Translate(0, driveSpeed, 0);
    }
}