using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    [SerializeField] public TurnManager ChangeTurn;
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Rigidbody characterBody;

    public GameObject hitmark;
    public ParticleSystem muzzleFlash;
    public GameObject BarrelEnd;
    private float Wait;

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                    Shoot();
                    characterBody.AddExplosionForce(800f, Vector3.back, 80f);
                    characterBody.AddExplosionForce(800f, Vector3.up, 80f); 
                    TurnManager.GetInstance().TriggerChangeTurn();
            }
       }
    }


    public void Shoot ()
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

            GameObject Impactgo = Instantiate(hitmark, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(Impactgo, 2f);
        }
    }
}
