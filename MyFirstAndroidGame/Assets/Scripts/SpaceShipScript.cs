using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour, ITouchable
{
    
    Vector3 acceleration, velocity;
    public void OnDrag(Ray collidingRay)
    {
        throw new System.NotImplementedException();
    }
    public void OnTap(Ray collidingRay)
    {
        print("SpaceShip tapped code here");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // acceleration = 9.8f * Vector3.down;                    // F = ma

        if (Input.touchCount > 0)
        {
            


            // acceleration += 15 * Vector3.up;
        }

        velocity += acceleration * Time.deltaTime;              // V = u + at
        transform.position += velocity * Time.deltaTime;      // S = ut
    }

    internal void changeColor(Color newColor)
    {
        GetComponent<Renderer>().material.color = newColor;
    }

    
}
