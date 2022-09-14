using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody CharacterBody;

    private bool isToutchingFloor;
    private int f_speed;
    void Update()
    {
        //are you toutchining the floor
        //if (isToutchingFloor);
        {
          //isToutchingFloor = true;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            isToutchingFloor = true;
            Debug.LogError("Nu trykerman på knappen");
            CharacterBody.AddForce(Vector3.up * 5000f);
            CharacterBody.AddForce(Vector3.fwd * 5000f);
            CharacterBody.AddForce(Vector3.right * 5000f);

        }
    }
    //you are toutching the floor
    private void OnCollisionEnter(Collision collision)
    {
        Debug.LogError("Its Working!!");
         isToutchingFloor = true;
    }
    

}
