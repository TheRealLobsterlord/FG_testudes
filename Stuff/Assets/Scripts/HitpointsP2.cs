using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitpointsP2 : MonoBehaviour
{
    public int p2Hp = 5;
    public TMP_Text P2_Hp;
    void Update()
    {
        P2_Hp.SetText("Hp: " + p2Hp);

    }
}
