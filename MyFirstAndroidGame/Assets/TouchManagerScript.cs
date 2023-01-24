using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManagerScript : MonoBehaviour
{
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch[] myTouches = Input.touches;
            Touch myFirstTouch = myTouches[0];
            print(myFirstTouch.position);
            timer += Time.deltaTime;
            switch (myFirstTouch.phase)
            {
                case TouchPhase.Began:
                    timer = 0f;

                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Moved:
                    break;
                case TouchPhase.Ended:
                    if (timer <= 0.5f)
                    {
                        Ray myRay1 = Camera.main.ScreenPointToRay(myFirstTouch.position);
                        RaycastHit hitObj;
                        Physics.Raycast(myRay1, out hitObj);
                        ITouchable touchedObject = hitObj.transform.GetComponent<ITouchable>();
                        touchedObject.OnTap(myRay1);
                    }
                    break;
            }
        
            

            Ray myRay = Camera.main.ScreenPointToRay(myFirstTouch.position);
            Debug.DrawRay(myRay.origin, 15 * myRay.direction);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo))
            {
                // hitInfo.transform.position += Vector3.up;
                // SpaceShipScript touchedSpaceShip = hitInfo.transform.GetComponent<SpaceShipScript>();
                // touchedSpaceShip.changeColor(Color.green);

                ITouchable touchedObject = hitInfo.transform.GetComponent<ITouchable>();
                //if (touchedObject != null)
                //    touchedObject.OnTap();

                if (touchedObject is SpaceShipScript)
                    (touchedObject as SpaceShipScript).changeColor(Color.green);
            }


            // acceleration += 15 * Vector3.up;
        }

    }
}
