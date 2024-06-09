using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sussy : MonoBehaviour
{
    // sus info needed
    public int susLvl = 0; 
    private float currentSusLvl = 0f; //d isplayed suspicion level for smooth transition
    public int increaseSus = 15; // Ttsting number
    public int maxSus = 78;

    // sus bar
    public Sprite[] barFrames; 
    public SpriteRenderer barSpriteRenderer; 

    // for da smooth bar
    public float susSpeed = 2f; // interpolation speed

    // get info from userInput
    public PlayerInput playerInput;

    void Start()
    {

        SusBar(0);
        StartCoroutine(SussySometimesRandom());
    }

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("ik ur greasy hands r on the space bar");
            IsSussy();
        }*/

        // so its smooootoh
        currentSusLvl = Mathf.Lerp(currentSusLvl, susLvl, Time.deltaTime * susSpeed);

        
        SusBar(currentSusLvl);
    }

    // randomly adjust suspicion level every few seconds
    private IEnumerator SussySometimesRandom()
    {
        while (true)
        {
 
            yield return new WaitForSeconds(5f);
            SussyRandom();
        }
    }

    // will run when the customer turns their head
    public void IsSussy()
    {
        Debug.Log("Player is at + " + playerInput.currentStation);
        if ((playerInput.currentStation == 1) || (playerInput.currentStation == 3))
        {
            Debug.Log(" Shit u were seen! ");
            IncSus(increaseSus);
        }
    }


    public void IncSus(int inc)
    {
        susLvl += inc;
        Debug.Log("I inc by " + inc);

        susLvl = Mathf.Clamp(susLvl, 0, maxSus);
        if (susLvl > maxSus)
        {
            Debug.Log("SUSSY OVERLOAD!");
        }
    }

  
    void SusBar(float amt)
    {
        if (barFrames.Length > 0 && barSpriteRenderer != null)
        {
            // SMOOTH
            int frameIndex = Mathf.RoundToInt((amt / maxSus) * (barFrames.Length - 1));

            // clamp so we know its in a certian rangle
            frameIndex = Mathf.Clamp(frameIndex, 0, barFrames.Length - 1);

            // new syssy sprite
            barSpriteRenderer.sprite = barFrames[frameIndex];
        }
    }

    // randomly decrease or increas cuz i want it
    void SussyRandom()
    {
        int randinc = Random.Range(0, 3);
        int randdec = Random.Range(0, 4);
        susLvl += randinc;
        susLvl -= randdec;
        susLvl = Mathf.Clamp(susLvl, 0, maxSus);
    }
}
