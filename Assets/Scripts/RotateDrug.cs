using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDrug : MonoBehaviour {

    float sensivity = 40f;
    
    float minAngle = -1f;
    float maxAngle = 180f;

    float previousAngle;

    private void Start()
    {
       
    }

    private void OnMouseDrag()
    {
        float newz = Input.GetAxis("Mouse X") * sensivity + transform.eulerAngles.z;
        CalculalteAngle(newz);
    }

    void CalculalteAngle(float angle)
    {
        angle = Mathf.Clamp(angle, minAngle, maxAngle);
        angle = (float)System.Math.Round(angle / 20) * 20;
        
        if (angle!=previousAngle)
        {
            transform.localEulerAngles = new Vector3(0, -90, angle);
            previousAngle = angle;
          
        }
        
        
       
    }

    Color CalculateColor(float angle)
    {
        switch ((int)angle)
        {
            case 20: return Color.white;
            case 40: return Color.blue;
            case 60: return Color.yellow;          
            case 80: return Color.green;
            case 100: return Color.red;
            default: return Color.white;

        }
    }

}
