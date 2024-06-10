using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEnd : MonoBehaviour
{
    public SpriteRenderer open;
    public Sprite[] openingList;
    public float frameInterval = 1.2f;

    public SpriteRenderer littleGuy;
    public Sprite[] littleGuyList;
    public float frameIntervalLil = 0.4f;
    void Start()
    {
        StartCoroutine(LittleSad());
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
            if (x % 1 == 1)
            {
                littleGuy.sprite = littleGuyList[0];
            }
            else
            {
                littleGuy.sprite = littleGuyList[1];
            }
            yield return new WaitForSeconds(frameIntervalLil);
        }
        
    }
}
