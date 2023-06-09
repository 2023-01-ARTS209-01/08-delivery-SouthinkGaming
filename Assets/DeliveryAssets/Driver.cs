using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {
    // Controles the stearing speed of the car
    [SerializeField] float stearSpeed = 1f;
    // Controles the driving speed of the car
    [SerializeField] float driveSpeed = 1f;
    // Start is called before the first frame update
    void Start() {}
    // Update is called once per frame
    void Update() {
        float steerAmount = Input.GetAxis("Horizontal") * stearSpeed * Time.deltaTime;
        float driveAmount = Input.GetAxis("Vertical") * driveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, driveAmount, 0);
    }
}