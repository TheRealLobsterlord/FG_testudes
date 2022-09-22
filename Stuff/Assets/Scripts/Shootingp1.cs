using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootingP1 : MonoBehaviour
{
    //[SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Rigidbody CharacterBody;
    [SerializeField] private bool recoil;
    public GameObject BarrelEnd;
    public static int dmg = 2;
    public static float fireRate = 2f;
    public bool hit1;


    private Camera Player1Cam;
    private float nextFire;
    void Start()
    {
        
    }

    void Update()
    {
        // shootingmcshootface
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextFire = Time.time + fireRate;
           // Debug.DrawRay(BarrelEnd.position, transform.forward * 50f, Color.red, 0.5f);

            RaycastHit result;
            bool hit1 = Physics.Raycast(BarrelEnd.transform.position, transform.TransformDirection(Vector3.forward), out result, Mathf.Infinity);
            Debug.DrawRay(BarrelEnd.transform.position, transform.forward * 50f, Color.red, 2f);

            // makes the tanks go yeet
            if (recoil)
            {
                CharacterBody.AddExplosionForce(2000f, Vector3.one, 2000f);
                CharacterBody.AddExplosionForce(2000f, Vector3.up, 2000f);
            }

            // are things hitting things
            if (hit1)
            {
                Debug.LogError("så pass" + result.collider);
            }
            // it is missing
            else
            {
                Debug.LogError("miss");
            }
   
        }

    }
}

