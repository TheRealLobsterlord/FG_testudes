using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Rigidbody CharacterBody;
    [SerializeField] private Camera playerCam;
    [SerializeField] int f_speed = (int)4;
    [SerializeField] int f_Rspeed = (int)4;
    public Vector3 point;
    void Update()
    {


        if (playerTurn.IsPlayerTurn())
        {
            playerCam.enabled = false;

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
                Vector3 direction = Vector3.forward * Input.GetAxis("Vertical");

                transform.Translate(direction * f_speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                Vector3 direction = Vector3.forward * Input.GetAxis("Vertical");

                transform.Translate(direction * f_Rspeed * Time.deltaTime);
            }

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                f_speed = (int)10;
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                f_speed = (int)4;
            }
            else
            {
                playerCam.enabled = true;
            }
        }

    }

}
