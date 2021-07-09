using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCloseKrblwka : MonoBehaviour
{
    public Animation anim;
    public bool KrblwkaIsClosed = true;
    public Text task;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private byte counter = 0;
    private byte counter2 = 0;
    private void OnMouseUpAsButton()
    {

       
        if (KrblwkaIsClosed)
        {
            
            
            anim.Play("OpenKrblwka", AnimationPlayMode.Queue);
           
            KrblwkaIsClosed = false;
            if (!PutWater.isTrubkaOut)
                task.text = "Достаньте трубку из поляриметра и вставьте \nтрубку с раствором сахара";
            
            else if(!putTrubkaScript.isTrubkaOut)
                task.text = "Достаньте трубку из поляриметра и вставьте \nтрубку с водой";
            
            else
                task.text = "Вставьте трубку с водой в поляриметр";


        }
        else
        {
            
            anim.Play("CloseKrblwkaKrblwka", AnimationPlayMode.Queue);
            KrblwkaIsClosed = true;
            if(SwitchPosition.tymlerOff)
            task.text = "Включите поляриметр";
            else
                task.text = "Посмотрите в глазок";


        }

    }


}
