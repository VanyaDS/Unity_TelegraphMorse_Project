using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchPosition : MonoBehaviour {

    public Light light;
    public Animation animation;
    public Text task;
    public static bool tymlerOff = true;

    void OnEnable()//при включении/содании объекта
    {
   
       
    }
  

    void FixedUpdate()
    {
        
       
    }

    private void OnMouseUpAsButton()
    {


        if (tymlerOff)
        {

            
            animation.Play("tymblerAnim", AnimationPlayMode.Queue);
            light.intensity = 100;
            task.text = "Посмотрите в глазок ";

            tymlerOff = false;
        }
        else
        {

            animation.Play("tymblerAnimOut", AnimationPlayMode.Queue);
            tymlerOff = true;
            light.intensity = 0;
            task.text = $"Концентрация сахара получилась {TableValues.resultToShow} г/см³";
        }

    }



}




