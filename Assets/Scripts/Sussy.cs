using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Sussy : MonoBehaviour
{

    // sus info needed
    public int susLvl = 0; 
    public int increaseSus = 8; // testing number
    public int maxSus = 78; 

    // sus bar
    public Sprite[] barFrames; 
    public SpriteRenderer barSpriteRenderer; 
    private int totalFrames = 79 ; 

    // get info from userInput
    
    public PlayerInput playerInput;

    void Start()
    {
        SusBar(0);
        StartCoroutine(SussySometimesRandom());
    }


    void Update()
    {
        // lemme test the sussybar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("ik ur greasy hands r on the space bar");
            IsSussy();
        }
        SusBar(susLvl); // keep the susbar in check girl
    }

// i want the susbar to always be dynamically increasing or decreasing randomly
    private IEnumerator SussySometimesRandom()
    {
        while (true)
        {
            // Wait for the specified interval
            yield return new WaitForSeconds(1f);

            // Update the suspicion level with random changes
            SussyRandom();
        }
    }
    // this fxn will run when the customer turns their head
    public void IsSussy()
    {
        Debug.Log("Player is at + " + playerInput.currentStation);
        if ((playerInput.currentStation == 1) || (playerInput.currentStation == 3))
        {
            
            Debug.Log(" Shit u were seen! ");
            IncSus(increaseSus);

        }
    }

    // increase sussyness
    public void IncSus(int inc)
    {
        susLvl += inc;
        // clamp so susLvl stays within a range and doesn't go too high or low
        susLvl = Mathf.Clamp(susLvl, 0, maxSus);
        SusBar(susLvl); // update susbar
        if (susLvl > maxSus)
        {
            Debug.Log("SUSSY OVERLOAD!");
        }
    }

        void SusBar(int amt)
    {
        if (barFrames.Length > 0 && barSpriteRenderer != null)
        {
            barSpriteRenderer.sprite = barFrames[susLvl];
        }
    }

        // increase or decrease suslvl by a random number at all times
        void SussyRandom()
        {
            int randinc = Random.Range(0, 3);
            int randdec = Random.Range(0, 4);
            susLvl += randinc;
            susLvl -= randdec;
            susLvl = Mathf.Clamp(susLvl, 0, maxSus);
        }



}
