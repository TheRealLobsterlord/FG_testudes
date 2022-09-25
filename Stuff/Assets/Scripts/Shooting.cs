using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    [SerializeField] private Rigidbody characterBody;
    public CharacterController IsMyTurn;

    public ParticleSystem muzzleFlash;
    public GameObject BarrelEnd;

    void Update()
    {
       if (IsMyTurn)
       {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                    Shoot();
                    characterBody.AddExplosionForce(800f, Vector3.back, 80f);
                    characterBody.AddExplosionForce(800f, Vector3.up, 80f);
             
            }
       }
    }


    void Shoot ()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(BarrelEnd.transform.position, BarrelEnd.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }

    }
}
