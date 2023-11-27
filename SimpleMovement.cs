using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour {
    [SerializeField]
    [Range(0.0f, 100.0f)]
    private float speed = 10.0f;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("w")) {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("s")) {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey("a")) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("d")) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
