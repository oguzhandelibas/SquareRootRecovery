using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FrameManager : MonoBehaviour
{
    private Image frameImage;

    int randomValue;
    Color color;
    void Start()
    {
        frameImage = GetComponent<Image>();
        ChangeColor();
    }


    void ChangeColor()
    {
        randomValue = Random.Range(0, 70);
        if(randomValue <= 10)
        {
            color = Color.magenta;
        }else if(randomValue <= 20)
        {
            color = Color.red;
        }
        else if (randomValue <= 30)
        {
            color = Color.green;
        }
        else if (randomValue <= 40)
        {
            color = Color.grey;
        }
        else if (randomValue <= 50)
        {
            color = Color.blue;
        }
        else if (randomValue <= 60)
        {
            color = Color.yellow;
        }
        else if (randomValue <= 70)
        {
            color = Color.cyan;
        }

        if (frameImage != null)
        {
            frameImage.color = color;
        }
    }
}
