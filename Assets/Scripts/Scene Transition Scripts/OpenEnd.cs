using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class OpenEnd : MonoBehaviour
{
    
    public SpriteRenderer open;
    public Sprite[] openingList;
    public float frameInterval = 1.2f;

    public SpriteRenderer littleGuy;
    public Sprite[] littleGuyList;
    public float frameIntervalLil = 0.4f;

    public SpriteRenderer hand;
    public Sprite[] handList;
    public float frameIntervalHand = 1.4f;
    public void NewGameButton()
    {
        SceneManager.LoadScene("Title");
    }
    void Start()
    {
        StartCoroutine(LittleSad());
        StartCoroutine(FloatHand());
        StartCoroutine(Opening());
        
    }

    // Update is called once per frame
 

    private IEnumerator Opening()
    {
        for (int i = 0; i < 5; i++)
        {
        open.sprite = openingList[i];
        yield return new WaitForSeconds(frameInterval);
        }
    
    }
    private IEnumerator LittleSad()
    {
        int x = 1;
        while(true)
        {
            if (x % 2 == 1)
            {
                littleGuy.sprite = littleGuyList[0];
            }
            else
            {
                littleGuy.sprite = littleGuyList[1];
            }
            yield return new WaitForSeconds(frameIntervalLil);
            
            x++;
        }
        
    }

    private IEnumerator FloatHand()
    {
        int y = 1;
        while(true)
        {
            if (y % 2 == 1)
            {
                hand.sprite = handList[0];
            }
            else
            {
                hand.sprite = handList[1];
            }
            yield return new WaitForSeconds(frameIntervalHand);
            y++;
    
        }
    }
}
