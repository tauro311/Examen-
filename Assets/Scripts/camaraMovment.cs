using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraMovment : MonoBehaviour
public vector2 miniPosition;
public vector2 maxPosition;

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector desieredPosition = player.position + new vector3(0, 0, -10);
        float Clamp.X.Mathf.Clamp(desieredPosition.X , miniPosition.X, maxPosition.X);
        float Clamp.Y.Mathf.Clamp(desieredPosition.Y, miniPosition.Y, maxPosition.Y);
        Vector3 clamoedPosition = new Vector3(clampX, clampY, desieredPosition.Z);
        transform.position = clampedPosition; 
    }
}
