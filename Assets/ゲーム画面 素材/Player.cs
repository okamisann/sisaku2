using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    private Animator animator;
    public float JumpPower = 6.0f;
    public Rigidbody rd;
    private float kakudo;
    private float kyori;
    float dx;
    float dy;
    float rad;
    private int Runhanntei=0;
    public float Runspeed = 0.1f;
    private int zimennhanntei = 0;
    public GameObject cube;
    int kougekihanntei=0;
    float counttime = 0;
    float Attacktime = 0;
    public GameObject cmr;

    void OnCollisionStay(Collision collision)
    {
        zimennhanntei = 1;
    }

    public void Attack()
    {
        if (Attacktime >= 0.5)
        {
            cube.SetActive(true);
            kougekihanntei = 1;
            animator.SetBool("Attacking", true);
            Attacktime = 0;
        }
    }

    public void Run()
    {
        if (Runhanntei == 0)
        {
            Runspeed = 0.2f;
            Runhanntei = 1;
        }
        else
        {
            if (Runhanntei == 1)
            {
                Runspeed = 0.1f;
                Runhanntei = 0;
            }
        }
    }

    public void Jump()
    {
        if (zimennhanntei == 1)
        {
            rd.velocity = new Vector3(0, JumpPower, 0);
            animator.SetBool("Jumping", true);
            zimennhanntei = 0;
        }
    }

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        rd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        animator.SetBool("Jumping", false);
        animator.SetBool("Attacking", false);
        GameObject cmr = GameObject.Find("ObservationCamera");
        dx = CrossPlatformInputManager.GetAxis("Horizontal");
        dy = CrossPlatformInputManager.GetAxis("Vertical");
        rad = Mathf.Atan2(dy, -dx);
        kakudo = rad * Mathf.Rad2Deg;
        kyori = Mathf.Abs(Mathf.Sqrt(Mathf.Pow(dx, 2) + Mathf.Pow(dy, 2)));
        counttime += Time.deltaTime;
        Attacktime += Time.deltaTime;

        if (dx != 0 && dy != 0)
        {
            transform.rotation = Quaternion.Euler(0f, kakudo + cmr.transform.localEulerAngles.y - 90, 0f);
            animator.SetBool("Running",true);
        }
        else
        {
            animator.SetBool("Running", false);
        }

        if (kyori > 0)
        {
            transform.position += transform.forward * (Runspeed * kyori);
        }

        if (kougekihanntei == 1 && counttime >= 0.2)
        {
            cube.SetActive(false);
            counttime = 0;
        }
    }
}
