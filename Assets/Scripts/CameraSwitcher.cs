using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField]
    GameObject rings;
    public Camera mainCamera;
    public Camera canvasCamera;
    private bool podpis = true;
    public static bool noChangeRotation = false;
    public Text task;
    public GameObject wkala;
    public static Quaternion wkalaRotation;
    public Image image;



    private bool first = true;
    private void OnMouseDown()
    {
        image.color = new Color32(255, 253, 0, 20);
        noChangeRotation = true;
        EventManager.MovedCamera();//вызываем событие для камеры для начала движения
        
        if (podpis)
        {
            EventManager.SwitchCan += Switch;//подписываемся на событие для переключения камер
            podpis = false;
        }
        if (first)
        {
            wkalaRotation = wkala.transform.rotation;
            first = false;
        }
        else
        wkala.transform.rotation = wkalaRotation;
    
    
    
    }

    private void Start()
    {
        rings.SetActive(false);
    }

    private static bool swit = false;
    public void Switch(bool onMain)
    {

        print("вызван switch c " + onMain);
        if (swit)
        {
            mainCamera.transform.position = new Vector3(4.62f, 10.42f, -124.82f);
           
            mainCamera.enabled = !mainCamera.enabled;
            canvasCamera.enabled = !canvasCamera.enabled;
            print("переключаемся на главную");
            swit = false;
            rings.SetActive(false);
            CameraSwitcher.noChangeRotation = false;
        }

        else
        {
            mainCamera.enabled = !mainCamera.enabled;
            canvasCamera.enabled = !canvasCamera.enabled;
            print("переключаемся с главной");
            swit = true;
            rings.SetActive(true);
            CameraSwitcher.noChangeRotation = false;
            task.text = "Поворачивайте маховик, пока изображение не станет максимально ярким,\nзатем снимите показания с лимба и занесите в таблицу";
        }

    }

}
