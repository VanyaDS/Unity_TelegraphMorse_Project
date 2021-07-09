using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tasks : MonoBehaviour
{

    [SerializeField]
    Text taskText;
    Image myimage;

    [SerializeField]
    Button addButton;
    [SerializeField]
    Image addButtonImage;

    [SerializeField]
    Button tableButton;
    [SerializeField]
    Image tableButtonImage;
    [SerializeField]

    Button clearTableButton;
    [SerializeField]
    Image clearTableButtonImage;

    [SerializeField]
    GameObject inputArea;

    bool isWorking;
    Color currentColor;

    bool wasTaskControl;

    int numberOfTask = 0;

    private void Start()
    {
        myimage = GetComponent<Image>();
        myimage.enabled = false;
        taskText.enabled = false;
        addButton.GetComponent<Image>().enabled = false;
        tableButton.GetComponent<Image>().enabled = false;
        clearTableButton.GetComponent<Image>().enabled = false;
        addButtonImage.enabled = false;
        tableButtonImage.enabled = false;
        clearTableButtonImage.enabled = false;
        inputArea.SetActive(false);



        EventManager.Switch += Task1;
    }

   


    

   

    //введение
    void Task1(bool w)
    {
        if (w)
        {
            EventManager.Switch -= Task1;
            taskText.text ="Откройте крышку поляриметра";
            EventManager.ColorChanger += Task2;
            Open();
        }
    }

    void Task2()
    {
        
        
            EventManager.ColorChanger -= Task2;
            EventManager.SwitchCan += Task3;
            Open();
        
    }

    void Task3(bool mainView)
    {
        
            EventManager.SwitchCan -= Task3;
            EventManager.WritingValue += Task4;
            Open();
        
    }

    //зеленый свет
    bool Task4()
    {
       
            EventManager.WritingValue -= Task4;
            EventManager.WritingValue += Task5;
            Open();
            return true;
        
       
    }

    bool Task5()
    {
        
            EventManager.WritingValue -= Task5;
            EventManager.WritingValue += Task6;
            Open(); return true;
        
      
    }

    bool Task6()
    {
        
            EventManager.WritingValue -= Task6;
            EventManager.ColorChanger += Task7;
            Open();
        return true;
      
    }

    //желтый свет
    void Task7()
    {
            EventManager.ColorChanger -= Task7;
            EventManager.WritingValue += Task8;
            Open();
        
    }

    bool Task8()
    {

            EventManager.WritingValue -= Task8;
            EventManager.WritingValue += Task9;
            Open(); return true;
        
     
    }

    bool Task9()
    {
            EventManager.WritingValue -= Task9;
            EventManager.WritingValue += Task10;
            Open();
            return true;
        
    }

    bool Task10()
    {
        

            EventManager.WritingValue -= Task10;
            EventManager.ColorChanger += Task11;
            Open();
            return true;
        
    }

    //красный цвет
    void Task11()
    {
        
            EventManager.ColorChanger -= Task11;
            EventManager.WritingValue += Task12;
            Open();
        
    }

    bool Task12()
    {
            EventManager.WritingValue -= Task12;
            EventManager.WritingValue += Task13;
            Open();
            return true;
       
    }

    bool Task13()
    {
            EventManager.WritingValue -= Task13;
            EventManager.WritingValue += Task14;
            Open();
            return true;
    }

    bool Task14()
    {      

            EventManager.WritingValue -= Task14;
            EventManager.ColorChanger += Task15;
            Open();
            return true;
    }

    //синий цвет
    void Task15()
    {
            EventManager.ColorChanger -= Task15;
            EventManager.WritingValue += Task16;
            Open();
        
    }

    bool Task16()
    {
       
            EventManager.WritingValue -= Task16;
            EventManager.WritingValue += Task17;
            Open();
            return true;
     
    }

    bool Task17()
    {
            EventManager.WritingValue -= Task17;
            EventManager.WritingValue += Task18;
            Open();
            return true;
    }

    bool Task18()
    {      
            EventManager.WritingValue -= Task18;
            Open();
            return true;
    }




    public void Open()
    {
        myimage.enabled = true;
        taskText.enabled = true;
        addButton.GetComponent<Image>().enabled = true;
        tableButton.GetComponent<Image>().enabled = true;
        clearTableButton.GetComponent<Image>().enabled = true;
        addButtonImage.enabled = true;
        tableButtonImage.enabled = true;
        clearTableButtonImage.enabled = true;
        inputArea.SetActive(true);
    }

    public void Close()
    {
        myimage.enabled = false;
        taskText.enabled = false;
        addButton.GetComponent<Image>().enabled = false;
        tableButton.GetComponent<Image>().enabled = false;
        clearTableButton.GetComponent<Image>().enabled = false;
        addButtonImage.enabled = false;
        tableButtonImage.enabled = false;
        clearTableButtonImage.enabled = false;
        inputArea.SetActive(false);
    }
    public void ResetTasks()
    {
        EventManager.SwitchWork(false);
        numberOfTask = 0;
        taskText.text ="Откройте крышку поляриметра";
        EventManager.Switch += Task1;
    }

}
