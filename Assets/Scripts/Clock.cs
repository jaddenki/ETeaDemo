using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Sprite[] timeSprites;
    public SpriteRenderer timeRenderer;
    public AudioSource ETea;

    public float timeLeft = 300f;
    public float test = 300f;
    int change = 0;
    public bool isDay;
    // Start is called before the first frame update
    void Start()
    {
        timeRenderer.sprite = timeSprites[0];
        ETea.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if(test >= timeLeft + (100.0f / 3))
        {
            isDay = true;
            change++;
            test = timeLeft;
            if(change >= 10)
            {
                change = 0;
            }
            timeRenderer.sprite = timeSprites[change];
        }


        if (timeLeft <= 0.0f)
        {
            timeRenderer.sprite = timeSprites[9];
            isDay = false;
            
            //code here that says to end the day
        }


    }
}
