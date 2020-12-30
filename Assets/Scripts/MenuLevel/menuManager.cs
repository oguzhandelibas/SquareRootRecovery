using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject aboutPanel;

    bool panelIsOpen;

    void Start()
    {
        panelIsOpen = false;
    }
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("MiddleLevel");
    }

    public void openThePanel()
    {
        if(!panelIsOpen){
        aboutPanel.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
    }else
    {
        aboutPanel.GetComponent<CanvasGroup>().DOFade(0, 0.5f);
    }
    }

    public void exitButton()
    {
        Application.Quit();
    }
    
}
