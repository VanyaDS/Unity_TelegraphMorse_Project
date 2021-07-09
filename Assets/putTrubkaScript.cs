using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class putTrubkaScript : MonoBehaviour
{
    public Animation anim;
    public static bool isTrubkaOut=true;
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
            
            anim.Play("trybkaAnim", AnimationPlayMode.Queue);
            isTrubkaOut = false;
            Counter++;
            if (Counter == 3)
                Counter = 0;
            task.text = "Закройте крышку поляриметра";
       
        }
          else
        {
            anim.Play("trybkaOut", AnimationPlayMode.Queue);
            isTrubkaOut = true;
        }
     

    }
}
