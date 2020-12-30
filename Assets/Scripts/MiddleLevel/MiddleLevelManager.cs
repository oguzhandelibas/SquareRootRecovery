using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;


public class MiddleLevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject playBtn, backBtn;

    [SerializeField]
    private GameObject fadePanel;

    [SerializeField]
    private GameObject inRootPrefab;

    [SerializeField]
    private Transform content;

    [SerializeField]
    private Sprite[] inRootImages, outRootImages;

    [SerializeField]
    private Image kokDisiImage;
    void Start()
    {
        fadePanel.SetActive(true);
        fadePanel.GetComponent<CanvasGroup>().alpha = 1;

        if(playBtn != null)
        {
            playBtn.GetComponent<RectTransform>().localScale = Vector3.zero;
        }

        if (backBtn != null)
        {
            backBtn.GetComponent<RectTransform>().localScale = Vector3.zero;
        }

        fadePanel.GetComponent<CanvasGroup>().DOFade(0, 1.5f).OnComplete(bringBtn);
        
    }
    void bringBtn()
    {
        fadePanel.SetActive(false);
        openTheBtn();
        createImageInList();
    }
    void openTheBtn()
    {
        playBtn.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        backBtn.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void BackBtn()
    {
        SceneManager.LoadScene("MenuLevel");
    }

    void createImageInList()
    {
        for (int i = 0; i < inRootImages.Length; i++)
        {
            GameObject rootItem = Instantiate(inRootPrefab, content);

            rootItem.GetComponent<btnManagerForRoot>().buttonNo = i;

            rootItem.transform.GetChild(3).GetComponent<Image>().sprite = inRootImages[i];

        }

        //kokDisiImage.sprite = outRootImages[0];
    }

    public void KokDisiResmiGoster(int buttonNo)
    {
        kokDisiImage.sprite = outRootImages[buttonNo];
    }
}
