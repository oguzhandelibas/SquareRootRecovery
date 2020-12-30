using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnManagerForRoot : MonoBehaviour
{
    [SerializeField]
    private Image kokiciImage;

    public int buttonNo;

    MiddleLevelManager middleLevelManager;

    private void Awake()
    {
        middleLevelManager = Object.FindObjectOfType<MiddleLevelManager>();
    }

    public void ButonaTiklandi()
    {
        middleLevelManager.KokDisiResmiGoster(buttonNo);
    }
}
