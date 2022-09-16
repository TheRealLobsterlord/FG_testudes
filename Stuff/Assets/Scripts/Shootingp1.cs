using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootingp1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit result;
            bool thereWasHit = Physics.Raycast(transform.position, transform.up, out result, Mathf.Infinity);

            DrawRay(transform.position, transform.up * 50f, Color.red, 0.05f);

            if (thereWasHit)
            {
                result.collider.gameObject.GetComponent<MeshRenderer>().material.color = GetRandomColor();
            }
        }
    }

    private Color GetRandomColor()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        return color;
    }
}