using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bullet_Shoot_Mechant : MonoBehaviour
{
    // public GameObject Capsule_Mechant;
    public Rigidbody projectile_Mechant;
    public Transform Spawnpoint_Mechant;
    public float projectile_Speed;
    public bool cooldown_Mechant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (cooldown_Mechant < 0)
      //  {
       ////     cooldown_Mechant = true;
       // }
    }

    private void Attack()
    {
        Rigidbody projectile_MechantInstance;
        projectile_MechantInstance = Instantiate(projectile_Mechant, Spawnpoint_Mechant.position, Spawnpoint_Mechant.rotation) as Rigidbody;
        projectile_MechantInstance.AddForce(Vector3.forward * projectile_Speed);
        Debug.LogError("TIR ENNEMI NE MARCHE PAS OH ");
    }
}
