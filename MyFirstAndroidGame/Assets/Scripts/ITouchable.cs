using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ITouchable
{
    void OnTap(Ray collidingRay);
    void OnDrag(Ray collidingRay);
}
