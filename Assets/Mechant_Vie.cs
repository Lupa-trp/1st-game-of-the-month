using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechant_Vie : MonoBehaviour
{
    public GameObject Mechant;

    // Start is called before the first frame update
    void Start()
    {
        life = 1;
    }
    public int life { get; protected set; }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        {
            if (other.gameObject.tag == "Bullet")
            {
                Debug.LogError("CA MARCHE PAS");

                life--;
            }
            if (life <= 0)
            {
                Destroy(gameObject);// si vie = 0 = enemy mort //

            }
        }
    }



    /*void Disappear()
    {
        Mechant.SetActive(false);
    }*/


    void Update()
    {
        // si bullet touche = vie -1 //
        

    }
}