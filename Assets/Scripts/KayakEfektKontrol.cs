using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KayakEfektKontrol : MonoBehaviour
{
  [SerializeField] private ParticleSystem _kayakEfekt;

   private void OnCollisionEnter2D(Collision2D other)
   {
      if (other.gameObject.tag == "Ground")
      {
         _kayakEfekt.Play();
      }
   }

   private void OnCollisionExit2D(Collision2D other)
   {
      if (other.gameObject.tag == "Ground")
      {
         _kayakEfekt.Stop();
      }
   }
}
