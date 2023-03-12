using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int cnt = 0;

    private void OnCollisionEnter(Collision cuCineNeCiocnim)
    {
        if (cuCineNeCiocnim.gameObject.tag != "Hit")
        {
            cnt++;
            Debug.Log("You've bumped into a thing this many times: " + cnt);
        }
    }
}