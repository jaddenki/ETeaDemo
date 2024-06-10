using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class TItle : MonoBehaviour
{
    public SpriteRenderer hai;
    public Sprite[] haiList;
    public float fii = 0.4f;
    public AudioSource title;
    public AudioSource select;


    public void NewGameButton()
    {
        select.Play();
        SceneManager.LoadScene("Intro");
    }
    void Start()
    {
        
        StartCoroutine(LittleSadHai());
        title.Play();
    }

    // Update is called once per frame
 


    private IEnumerator LittleSadHai()
    {
        int x = 1;
        while(true)
        {
            if (x % 2 == 1)
            {
                hai.sprite = haiList[0];
            }
            else
            {
                hai.sprite = haiList[1];
            }
            yield return new WaitForSeconds(fii);
            
            x++;
        }
        
    }


}
