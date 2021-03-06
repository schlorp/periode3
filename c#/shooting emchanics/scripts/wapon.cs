using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wapon : MonoBehaviour
{
    public Transform firepoint;
    private AudioSource shot;
    public ParticleSystem smoke;
    Animator anim;

    private int damage = 0;
    public int mindamage = 10;
    public int maxdamage = 15;

    public int Ammo = 5;

    public float firecap = 1;
    bool AllowFire = true;

    private void Start()
    {
        shot = GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();

    }
    void Update() {
        if (Input.GetButtonDown("Fire1") && (Ammo >= 1) && (AllowFire == true))
        {
            shoot();
            shot.Play();
            smoke.Play();
            anim.Play("flintlock_fire");

        }
        if (Input.GetButtonDown("Fire1") && (Ammo <= 0))
        {
            Debug.Log("Empty!");
        }
    }

    void shoot ()
    {
        StartCoroutine(waitforsec());

        RaycastHit2D hitinfo = Physics2D.Raycast(firepoint.position, firepoint.right);

        //haalt 1 ammo weg als je schiet
        if (Ammo > 0)
        {
            Ammo -= 1;
            Debug.Log(Ammo);
        }

        if (hitinfo)
        {
            Debug.Log(hitinfo.transform.name);

            enemy enemy = hitinfo.transform.GetComponent<enemy>();
            if(enemy != null)
            {
                damage = Random.Range(mindamage, maxdamage);
                enemy.Takedamage(damage);
                Debug.Log(damage);
            }
        }
    }
    private IEnumerator waitforsec()
    {
        AllowFire = false;
        yield return new WaitForSeconds(firecap);
        AllowFire = true;
    }
}
