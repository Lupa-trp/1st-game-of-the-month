using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Bullet_shoot : MonoBehaviour
{
    //public GameObject Capsule;
    public Rigidbody projectile;
    public Transform Spawnpoint;
    public GameObject bullet;




    /*void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.tag == "Mechant")
            {
                Destroy(gameObject);
            }
        }
    }*/

    /*void OnCollisionEnter(Collision other)
    {
        {
            if (other.gameObject.tag == "Mechant")
            {

                Destroy(gameObject);// si vie = 0 = enemy mort //
            }

            
        }
    }*/




    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);

            clone.velocity = Spawnpoint.TransformDirection(Vector3.forward * 100);
        }
    }


    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}