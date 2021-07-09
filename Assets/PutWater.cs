using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PutWater : MonoBehaviour
{
    public Animation anim;
    public static bool isTrubkaOut = true;
    public static byte Counter = 0;
    public Text task;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseUpAsButton()
    {

        if (isTrubkaOut)
        {

            anim.Play("PutWaterAnim", AnimationPlayMode.Queue);
            isTrubkaOut = false;
            Counter++;
            if (Counter == 3)
                Counter = 0;
            task.text = "Закройте крышку поляриметра";

        }
        else
        {
            anim.Play("OutWaterAnim", AnimationPlayMode.Queue);
            isTrubkaOut = true;
        }


    }
}
