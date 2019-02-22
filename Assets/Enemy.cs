using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private int HP = 1000;
    private int damage = 100;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Weapon")
        {
            HP = HP - damage;
            var num = HP;
            Debug.Log(num);
            if (HP <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
