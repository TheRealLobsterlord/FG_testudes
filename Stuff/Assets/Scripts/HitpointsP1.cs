using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitpointsP1 : MonoBehaviour
{
    public int p1Hp = 5;
    public TMP_Text P1_Hp;
    void Update()
    {
        P1_Hp.SetText("Hp: " + p1Hp);

    }
}
