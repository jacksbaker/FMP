﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject enemy;
    //public GameObject hitEffect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.tag == "Enemy")
    //    {
    //        Destroy(other);
    //    }


    //}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
            
    }
}
