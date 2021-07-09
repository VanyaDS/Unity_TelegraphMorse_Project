using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class MorseCode : MonoBehaviour
{
  static  char[] characters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                                        'J', 'К', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
                                                        'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2',
                                                        '3', '4', '5', '6', '7', '8', '9', '0', '6', '7',
                                                        '8', '9', '0','.',',','!',':',';','?', };

    static  string[] codeMorse = new string[] { "*–", "–***", "–*–*", "–**",
                                                        "*", "**–*", "––*", "****",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*",
                                                        "––*–", "*–*", "***", "–",
                                                        "**–", "***–", "*––",
                                                        "–**–", "–*––", "−−**",
                                                        "*−−−−",  "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−−−−*", "−−−−−",
                                                        "*–*–*–","––**––","–*–*––","–––***","–*–*–*","**––**","**–*–" };
    

    public static string DecryptMessage (StringBuilder message)
    {
        message.Remove(message.Length-1, 1);
        string[] messageArray = message.ToString().Split(' ');
        string resultString = "";
       
        int currentIndex = 0;
        foreach ( string text in messageArray)
        {
            
            currentIndex = Array.IndexOf(codeMorse, text);
            resultString += characters[currentIndex];
        }
        return resultString;
    }


}
