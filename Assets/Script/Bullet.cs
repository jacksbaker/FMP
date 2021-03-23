using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject enemy;

    public float waitTime = 0.2f;
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

        else
        {

            if (waitTime > 0)
            {
                waitTime -= Time.deltaTime;
            }
            
            
            if(waitTime < 0)
            {
                waitTime = 0;
                Destroy(gameObject);
            }
        }
            
    }
}
