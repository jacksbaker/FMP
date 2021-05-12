using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    public float waitTime;
    public float resetWaitTime;



    // Start is called before the first frame update
    void Start()
    {
        resetWaitTime = waitTime;
    }


    // Update is called once per frame
    void Update()
    {

        waitTime = waitTime - Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && waitTime <= 0)
        {
           Shoot();
           waitTime = resetWaitTime;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
