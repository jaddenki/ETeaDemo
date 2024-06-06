// yep this is the mommy script. we will need a queue script and stuff
// but in this script i imagine it would include the order gotten from the GetOrder function thing, get the player input, check when player checks ?!?!?! 
// should have a system that displays customer queue, navigate through it, 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // imma try singleton shit

    public PlayerInput playerInput; // player input script reference!

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
