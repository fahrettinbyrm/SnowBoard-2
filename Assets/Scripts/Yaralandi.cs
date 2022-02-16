using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yaralandi : MonoBehaviour
{
    [SerializeField] private float sahneYuklemeSuresi = 0.5f;

    [SerializeField] private ParticleSystem yaralandiEffect;

    [SerializeField] private AudioClip yaraSesi;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {   
            yaralandiEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(yaraSesi);
            Invoke("yenidenSahneYukle",sahneYuklemeSuresi);
        }
    }

    void yenidenSahneYukle()
    {
        SceneManager.LoadScene(0);
    }
}
