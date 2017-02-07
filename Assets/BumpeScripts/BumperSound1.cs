using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BumperSound1 : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player")) //If Ball Touches bumper sound plays
            GetComponent<AudioSource>().Play();
    }
}
