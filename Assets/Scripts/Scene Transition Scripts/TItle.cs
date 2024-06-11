using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TItle : MonoBehaviour
{
    public SpriteRenderer hai;
    public Sprite[] haiList;
    public float fii = 0.4f;
    public AudioSource title;

    public AudioSource select;

    public Tutorial tutorial;
    
    public GameObject[] buttons2Hide;


    public void NewGameButton()
    {
        select.Play();
        SceneManager.LoadScene("Intro");
    }

    public void ShowTutorial()
    {
        // Hide all the buttons when showing the tutorial
        foreach (GameObject uiElement in buttons2Hide)
        {
            uiElement.SetActive(false);
        }

        tutorial.canShow = true;
        tutorial.tutorialYas.SetActive(true);

        // Ensure the first slide is shown when tutorial starts
        tutorial.spriteIndex = 0;
        tutorial.tut.sprite = tutorial.tutSlides[0];
    }

    void Start()
    {
        StartCoroutine(LittleSadHai());
        title.Play();
    }

    private IEnumerator LittleSadHai()
    {
        int x = 1;
        while(true)
        {
            hai.sprite = haiList[x % haiList.Length];
            yield return new WaitForSeconds(fii);
            x++;
        }
    }
}
