using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{   
    [SerializeField] private float sahneYuklemeSuresi = 2f;

    [SerializeField] private ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {   
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("yenidenSahneYukle",sahneYuklemeSuresi);
        }
    }
    
    void yenidenSahneYukle()
    {
        SceneManager.LoadScene(0);
    }
}
