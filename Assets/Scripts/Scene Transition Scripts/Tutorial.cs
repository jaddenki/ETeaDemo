using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public TItle title;
    public bool canShow;
    public Sprite[] tutSlides;
    public SpriteRenderer tut;
    public Sprite clear;
    public GameObject tutorialYas;
    public int spriteIndex = 0;

    void Start()
    {
        canShow = false;
        tut.sprite = clear;
    }

    void Update()
    {
        if (canShow)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                // Move to the previous slide
                if (spriteIndex > 0)
                {
                    spriteIndex--;  // Decrement the index first
                    tut.sprite = tutSlides[spriteIndex];
                    Debug.Log("Previous Slide: " + spriteIndex);
                }
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                // Move to the next slide
                if (spriteIndex < tutSlides.Length - 1)
                {
                    spriteIndex++;  // Increment the index first
                    tut.sprite = tutSlides[spriteIndex];
                    Debug.Log("Next Slide: " + spriteIndex);
                }
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                // Exit the tutorial
                tutorialYas.SetActive(false);
                canShow = false;
                spriteIndex = 0;
                tut.sprite = clear;

                // Re-enable the UI elements hidden by the tutorial
                foreach (GameObject uiElement in title.buttons2Hide)
                {
                    uiElement.SetActive(true);
                }
            }
        }
    }
}
