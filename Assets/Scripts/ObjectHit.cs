using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision cuCineNeCiocnim)
    {
        if (cuCineNeCiocnim.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;

            // daca lasam doar gameObject.tag se va referi la obiectul de care este atasat scriptul si nu la obiectul cu care ne ciocnim
            gameObject.tag = "Hit";
        }
    }
}