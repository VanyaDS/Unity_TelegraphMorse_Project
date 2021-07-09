using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replacer : MonoBehaviour
{
    bool move = false;
    Vector3 startPosition;
    Vector3 needPosition;
    float speed = 0.01f;
    float offset = 0;
    Quaternion startRotation;
    Quaternion needRotaton;

    bool switching;

    private void OnEnable()
    {
        EventManager.Moved += Move;
    }

    private void Move()
    {
        if(!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(4.498f, 9.725f, -127.93f);
            needRotaton = new Quaternion(10.779f, -183.552f, 0, 0);
            switching = true;
            
        }
       
    }

    public void MoveTo(Transform t)
    {
        startPosition = transform.position;
       startRotation = transform.rotation;
        needPosition = t.transform.position;
       needRotaton = t.transform.rotation;
        offset = 0;
        move = true;
    }

    void FixedUpdate()
    {

        if(move)
        {

            offset+=speed;
             transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            if (CameraSwitcher.noChangeRotation)
            {
                
            }
            else 
            {
                transform.rotation = Quaternion.Lerp(startRotation, needRotaton, offset);
            }
            
            
            
            // mainCamera.transform.rotation = new Quaternion(6.795001f, -176.61f, 0, 0);

            if (offset >= 1)
            {
              //  transform.rotation = new Quaternion(10.779f, -183.552f,0, 0);
                move = false;
                offset = 0;
                print("вызываем событие по окончанию движения");

                if (CameraSwitcher.noChangeRotation)
                {


                    if (switching)
                    {
                        switching = false;
                        EventManager.SwitchCanvas(false);
                    }
                    else
                    {
                        switching = true;
                        EventManager.SwitchCanvas(true);
                    }
                }
            }
        }
    }
}
