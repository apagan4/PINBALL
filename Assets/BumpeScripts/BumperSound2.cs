using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BumperSound2 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
            GetComponent<AudioSource>().Play();
    }
}
