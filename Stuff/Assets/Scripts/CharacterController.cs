using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody CharacterBody;
    [SerializeField] int f_speed = (int)4;
    [SerializeField] int f_Rspeed = (int)4;
    public bool shoot;
    public Vector3 point;
    void Update()
    {
        //are you toutchining the floor
        //if (isToutchingFloor);
        {
            //isToutchingFloor = true;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 30 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up, 30 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            Vector3 newRotation = new Vector3(0, 0, 0);
            transform.eulerAngles = newRotation;
        }



        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direction = Vector3.fwd * Input.GetAxis("Vertical");

            transform.Translate(direction * f_speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 direction = Vector3.fwd * Input.GetAxis("Vertical");

            transform.Translate(direction * f_Rspeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Shoot ();

            CharacterBody.AddForce(Vector3.fwd * -800f);
            CharacterBody.AddExplosionForce(800f, Vector3.up, 00f);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            f_speed = (int)10;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            f_speed = (int)4;
        }

    }

    private void Shoot()
    {
        Debug.LogAssertion("Yeet");
    }

}
