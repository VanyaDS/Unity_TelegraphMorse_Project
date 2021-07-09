using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
public class DotDashKey : MonoBehaviour
{
    public Animation dotDashAnimation;
    DateTime clickDuration;
    DateTime pauseDuration;
    public AudioClip dotSound;
    public AudioClip dashSound;
    StringBuilder resultMessage = new StringBuilder();
    
    public Text showMessage;
    bool start = true;

    [System.Obsolete]
    private void OnMouseUp()
    {
        
        TimeSpan duration;
        duration = DateTime.Now - clickDuration;
        if (duration.TotalMilliseconds >= 200)
        {
           GetComponent<AudioSource>().PlayOneShot(dashSound);
            dotDashAnimation.Play("dash", AnimationPlayMode.Queue);
            resultMessage.Append('–');
         
            if (resultMessage.ToString()=="**–*–")
            {
                showMessage.text += " | end of message";
            }
        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(dotSound);
            dotDashAnimation.Play("dot", AnimationPlayMode.Queue);
            resultMessage.Append('*');
        }
       
    }

    [Obsolete]

    private void OnMouseUpAsButton()
    {
        TimeSpan durationBetweenSymbolsAndWords;
        if (!start)
        {
            durationBetweenSymbolsAndWords = DateTime.Now - pauseDuration;
            
            if (durationBetweenSymbolsAndWords.TotalMilliseconds >= 2000)
            {
                resultMessage.Append(' ');
                showMessage.text += MorseCode.DecryptMessage(resultMessage);
                resultMessage.Clear();
            }

            if (durationBetweenSymbolsAndWords.TotalMilliseconds >= 8000)
            {

                showMessage.text += " ";
            }
            start = true;
        }

        if (start)
        {
            pauseDuration = DateTime.Now;
            start = false;
        }
    }
    private void OnMouseDown()
    {
        clickDuration = DateTime.Now;
        
    }




}
