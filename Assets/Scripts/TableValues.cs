using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableValues : MonoBehaviour
{
    [SerializeField]
    Text[] allX0;

    [SerializeField]
    Text[] allX;

    [SerializeField]
    Text[] allFi;




    [SerializeField]
    Text fiAvg;

    [SerializeField]
    Text resultC;

    [SerializeField]
    Text lValue;


    [SerializeField]
    Text fiValue0;

    [SerializeField]
    InputField textInput;

    Text[][] matrix = new Text[2][];

    public Text task;
    public static string resultToShow;
    void Start()
    {
        matrix[0] = allX0;
        matrix[1] = allX;
        matrix[2] = allFi;

    }

    public void WriteValue()
    {
        if ( textInput.text == "")
        {
            task.text = "Для начала введите значение для записи в таблицу";
            return;

        }
        double a;
        if (!double.TryParse(textInput.text,out a))
        {
            task.text = "Некорректно введено значение.\nПопробуйте снова";
            textInput.text="";
            return;

        }
        if (allX0[0].text == "-")
        {
            allX0[0].text = textInput.text;
            textInput.text = null;
            task.text = "Откройте крышку поляриметра";
            return;
        }
        if (allX[0].text == "-")
        {
            allX[0].text = textInput.text;
            textInput.text = null;
            task.text = "Откройте крышку поляриметра";
            return;
        }
        if (allX0[1].text == "-")
        {
            allX0[1].text = textInput.text;
            textInput.text = null;
            task.text = "Откройте крышку поляриметра";
            return;
        }

        if (allX[1].text == "-")
        {
            allX[1].text = textInput.text;
            textInput.text = null;
            task.text = "Откройте крышку поляриметра";
            return;
        }
        if (allX0[2].text == "-")
        {
            allX0[2].text = textInput.text;
            textInput.text = null;
            task.text = "Откройте крышку поляриметра";
            return;
        }


        if (allX[2].text == "-")
        {
            allX[2].text = textInput.text;
            textInput.text = null;
            task.text = "Выключите установку";

            allFi[0].text =Math.Round((Math.Abs(Convert.ToDouble(allX0[0].text) - Convert.ToDouble(allX[0].text))),2).ToString();
            allFi[1].text = Math.Round((Math.Abs(Convert.ToDouble(allX0[1].text) - Convert.ToDouble(allX[1].text))), 2).ToString();
            allFi[2].text = Math.Round((Math.Abs(Convert.ToDouble(allX0[2].text) - Convert.ToDouble(allX[2].text))), 2).ToString();

            fiAvg.text = (Math.Round(((Convert.ToDouble(allFi[0].text) + Convert.ToDouble(allFi[1].text) + Convert.ToDouble(allFi[2].text))/3),2)).ToString();
            double result = Math.Round(Convert.ToDouble(fiAvg.text) / (66.53 * 2), 2);
            resultC.text = result.ToString();
            resultToShow  = result.ToString();
            return;
        }

    }
   

    public void Clean()
    {
        fiAvg.text = "-";
        resultC.text = "-";
      

        foreach (var item in allFi)
        {
            item.text = "-";
        }

        foreach (Text[] t in matrix)
        {
            for(int i = 0; i<t.Length; i++)
            {
                t[i].text = "-";
            }           

        }
    }
}
