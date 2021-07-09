using UnityEngine;
using UnityEngine.UI;

public class RotateMaxovik : MonoBehaviour
{
    public GameObject wkala;
    public Image imageOr;


  
    float a = 0;
    private void OnMouseDrag()
    {
        if (!putTrubkaScript.isTrubkaOut)
        {
            a = wkala.transform.rotation.z;
            transform.Rotate(0, 0, Input.GetAxis("Mouse X") * 5f);
            wkala.transform.Rotate(0, 0, Input.GetAxis("Mouse X") * 5f);
          
            if (putTrubkaScript.Counter == 1)
            {
               
                if (a >= -0.99f && a <= -0.9f)
                    imageOr.color = new Color32(255, 253, 0, 20);

                else if (a > -0.9f && a <= -0.8f)
                    imageOr.color = new Color32(255, 253, 0, 51);

                else if (a > -0.8f && a <= -0.7f)
                    imageOr.color = new Color32(255, 253, 0, 102);

                else if (a > -0.7f && a <= -0.6f)
                    imageOr.color = new Color32(255, 253, 0, 153);

                else if (a > -0.6f && a <= -0.5f)
                    imageOr.color = new Color32(255, 253, 0, 204);

                else if (a > -0.5f && a <= -0.45f)
                    imageOr.color = new Color32(255, 253, 0, 255);
                else if (a > -0.45f && a <= -0.3f)
                    imageOr.color = new Color32(255, 253, 0, 138);
                else
                    imageOr.color = new Color32(255, 253, 0, 20);
            }
           else if (putTrubkaScript.Counter == 2)
            {
                if (a >= -0.99f && a <= -0.96f)
                    imageOr.color = new Color32(255, 253, 0, 20);

                else if (a > -0.96f && a <= -0.86f)
                    imageOr.color = new Color32(255, 253, 0, 51);

                else if (a > -0.86f && a <= -0.76f)
                    imageOr.color = new Color32(255, 253, 0, 102);

                else if (a > -0.76f && a <= -0.66f)
                    imageOr.color = new Color32(255, 253, 0, 153);

                else if (a > -0.66f && a <= -0.56f)
                    imageOr.color = new Color32(255, 253, 0, 204);

                else if (a > -0.56f && a <= -0.51f)
                    imageOr.color = new Color32(255, 253, 0, 255);
                else if (a > -0.51f && a <= -0.36f)
                    imageOr.color = new Color32(255, 253, 0, 138);
                else
                    imageOr.color = new Color32(255, 253, 0, 20);
            }
            else
            {
                if (a >= -0.99f && a <= -0.82f)
                    imageOr.color = new Color32(255, 253, 0, 30);

                else if (a > -0.82f && a <= -0.72f)
                    imageOr.color = new Color32(255, 253, 0, 51);

                else if (a > -0.72f && a <= -0.62f)
                    imageOr.color = new Color32(255, 253, 0, 102);

                else if (a > -0.62f && a <= -0.52f)
                    imageOr.color = new Color32(255, 253, 0, 153);

                else if (a > -0.52f && a <= -0.42f)
                    imageOr.color = new Color32(255, 253, 0, 204);

                else if (a > -0.42f && a <= -0.37f)
                    imageOr.color = new Color32(255, 253, 0, 255);
                else if (a > -0.37f && a <= -0.22f)
                    imageOr.color = new Color32(255, 253, 0, 138);
                else
                    imageOr.color = new Color32(255, 253, 0, 20);
            }
        }
       
        if(!PutWater.isTrubkaOut)
        {
            a = wkala.transform.rotation.z;
            transform.Rotate(0, 0, Input.GetAxis("Mouse X") * 5f);
            wkala.transform.Rotate(0, 0, Input.GetAxis("Mouse X") * 5f);
 
            if (PutWater.Counter == 1)
            {

                if (a >= -0.98f && a <= -0.95f)
                    imageOr.color = new Color32(255, 253, 0, 20);

                else if (a > -0.95f && a <= -0.9f)
                    imageOr.color = new Color32(255, 253, 0, 51);

                else if (a > -0.9f && a <= -0.8f)
                    imageOr.color = new Color32(255, 253, 0, 102);

                else if (a > -0.8f && a <= -0.7f)
                    imageOr.color = new Color32(255, 253, 0, 153);

                else if (a > -0.7f && a <= -0.6f)
                    imageOr.color = new Color32(255, 253, 0, 204);

                else if (a > -0.6f && a <= -0.55f)
                    imageOr.color = new Color32(255, 253, 0, 255);
                else if (a > -0.55f && a <= -0.4f)
                    imageOr.color = new Color32(255, 253, 0, 138);
                else
                    imageOr.color = new Color32(255, 253, 0, 20);
            }
            else if (PutWater.Counter == 2)
            {
                if (a >= -0.99f && a <= -0.97f)
                    imageOr.color = new Color32(255, 253, 0, 20);

                else if (a > -0.97f && a <= -0.96f)
                    imageOr.color = new Color32(255, 253, 0, 51);

                else if (a > -0.96f && a <= -0.86f)
                    imageOr.color = new Color32(255, 253, 0, 102);

                else if (a > -0.86f && a <= -0.76f)
                    imageOr.color = new Color32(255, 253, 0, 153);

                else if (a > -0.76f && a <= -0.66f)
                    imageOr.color = new Color32(255, 253, 0, 204);

                else if (a > -0.66f && a <= -0.61f)
                    imageOr.color = new Color32(255, 253, 0, 255);
                else if (a > -0.61f && a <= -0.46f)
                    imageOr.color = new Color32(255, 253, 0, 138);
                else
                    imageOr.color = new Color32(255, 253, 0, 20);
            }
            else
            {
                if (a >= -0.99f && a <= -0.92f)
                    imageOr.color = new Color32(255, 253, 0, 30);

                else if (a > -0.92f && a <= -0.82f)
                    imageOr.color = new Color32(255, 253, 0, 51);

                else if (a > -0.82f && a <= -0.72f)
                    imageOr.color = new Color32(255, 253, 0, 102);

                else if (a > -0.72f && a <= -0.62f)
                    imageOr.color = new Color32(255, 253, 0, 153);

                else if (a > -0.62f && a <= -0.52f)
                    imageOr.color = new Color32(255, 253, 0, 204);

                else if (a > -0.52f && a <= -0.47f)
                    imageOr.color = new Color32(255, 253, 0, 255);
                else if (a > -0.47f && a <= -0.32f)
                    imageOr.color = new Color32(255, 253, 0, 138);
                else
                    imageOr.color = new Color32(255, 253, 0, 20);
            }
        }

    }
    //void OnGUI()
    //{
    //    int w = Screen.width, h = Screen.height;

    //    GUIStyle style = new GUIStyle();

    //    Rect rect = new Rect(0, 0, w, h * 2 / 100);
    //    style.alignment = TextAnchor.UpperLeft;
    //    style.fontSize = h * 5 / 100;
    //    style.normal.textColor = Color.white;
    //    string text = a.ToString();
    //    GUI.Label(rect, text, style);
    //}
}
