using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer renderer;
    private Rigidbody rigidbody;
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Time.time este perioada de timp de cand am inceput jocul pana in momentul curent (va creste incontinuu cat timp inca suntem in joc)
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}