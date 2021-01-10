using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Latte was here :)

    public int velocity;
    public string[] items;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if(x != 0 || y!= 0)
        {
            transform.Translate(x * Time.deltaTime * velocity, y * Time.deltaTime * velocity , 0);
        }

        if (Input.GetKey("space"))
        {
            Debug.Log("Something Happened! You pressed the spacebar.");
        }
    }

    private void FixedUpdate()
    {
        

    }
}
