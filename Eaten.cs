using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eaten : MonoBehaviour {

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            audioSource.Play();
        }
    }
}
