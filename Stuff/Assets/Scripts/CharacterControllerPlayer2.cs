using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CharacterControllerPlayer2 : MonoBehaviour
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

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 30 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up, 30 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.M))
        {
            Vector3 newRotation = new Vector3(0, 0, 0);
            transform.eulerAngles = newRotation;
        }



        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direction = Vector3.fwd * Input.GetAxis("Vertical");

            transform.Translate(direction * f_speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 direction = Vector3.back * Input.GetAxis("Vertical");

            transform.Translate(direction * -f_Rspeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            //Shoot ();

            CharacterBody.AddForce(Vector3.fwd * -800f);
            CharacterBody.AddExplosionForce(800f, Vector3.up, 00f);
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            f_speed = (int)10;
        }

        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            f_speed = (int)4;
        }

    }

    private void Shoot()
    {
        Debug.LogAssertion("Yeet");
    }

}
