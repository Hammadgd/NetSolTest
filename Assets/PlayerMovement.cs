using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerMovement : MonoBehaviour
{
    public float force;
    private Rigidbody rb;
    public List<GameObject> enemies;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        SpawningEnemies();
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.forward);
    }

    void FixedUpdate()
    {
        float horizontalInput = -Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(horizontalInput, verticalInput, 0) * (force * Time.deltaTime));
    }

    private void SpawningEnemies()
    {
        foreach (GameObject go in enemies)
        {
            Instantiate(go, new Vector3((Random.Range(0,15)),Random.Range(10,40),Random.Range(30,100)), Quaternion.identity);
        }
    }
}
