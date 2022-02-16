using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float torkMiktari = 1f;
    [SerializeField] private float hizlandir;
    [SerializeField] private float normalHiz;

    private SurfaceEffector2D _surfaceEffector2D;
    
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        _surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRotate();
        playerHizlandir();
    }
   
    
    void playerRotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torkMiktari);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torkMiktari);
        }
    }

    void playerHizlandir()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _surfaceEffector2D.speed = hizlandir;
        }
        else
        {
            _surfaceEffector2D.speed = normalHiz;
        }
    }
}
