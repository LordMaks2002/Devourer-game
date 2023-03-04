using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Skill_1Fireball : MonoBehaviour
{
    Rigidbody rb;
    public GameObject FireBall;
    public GameObject Spawn_FireBall;
    public float speed = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            Instantiate(FireBall, Spawn_FireBall.transform.position, Quaternion.identity);
        }
           FireBall.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(1, 0, 1) * speed);
    }
}
