using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mechant_Movement : MonoBehaviour
{
    public float delta = 1.5f;  // Gauche droite petit déhancher 
    public float speed = 5.0f;
    private Vector3 startPos;

    public NavMeshAgent Enemy;
    public Transform Joueur;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;

        Enemy.SetDestination(Joueur.position);
    }
}
