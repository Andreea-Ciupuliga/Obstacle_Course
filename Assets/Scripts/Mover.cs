using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 500f; //[SerializeField] este la fel ca public si anume ca putem sa ii modifica valoarea din inspector

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKey("w")) //daca apasam pe sageata sus de la tastatura
            rb.AddForce(0, 0, moveSpeed * Time.deltaTime); //se deplaseaza pe axa Z (asa le-am pozitionat in proiect)
    
        if (Input.GetKey("s")) 
            rb.AddForce(0, 0, -moveSpeed * Time.deltaTime);
    
        if (Input.GetKey("a")) 
            rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0);
        
        if (Input.GetKey("d")) 
            rb.AddForce(moveSpeed * Time.deltaTime, 0, 0);
    }
}