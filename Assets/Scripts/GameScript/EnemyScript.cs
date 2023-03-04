using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

public class EnemyScript : MonoBehaviour
{
    public float HP = 100;
    public GameObject Died;
    public GameObject Enemy_mob;
    public bool peremenaja;

    void Update()
    {
        if (HP <= 2)
        {
            peremenaja = true;
        }
        else
        {
            peremenaja = false;
        }

        if (HP < 0)
        {
            Instantiate(Died, transform.position, transform.rotation);
            Destroy(Enemy_mob);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DamageTrigerToEnemy_1"))
        {
            HP--;
        }
    }
}
