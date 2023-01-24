using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour, ITouchable
{
    public void OnDrag(Ray collidingRay)
    {
        throw new System.NotImplementedException();
    }
    public void OnTap(Ray collidingRay)
    {
        print("Sphere tapped code here");
    }

    public void OnTap()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
