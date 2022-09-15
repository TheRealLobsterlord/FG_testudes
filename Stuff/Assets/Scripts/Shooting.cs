using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    void Update()
    {
        RaycastHit result;
        bool ShotHit = Physics.Raycast(transform.position, transform.forward, out result, Mathf.Infinity);

        Debug.DrawRay(transform.position, transform.forward * 50f, Color.red, 0.05f);

        
    }








}
