//ngl this code is probably gonna suck
//this should have a customer appear on screen (assuming 2 sec appearing animation, some number of sec standing, 2 sec walking away)
using System.Collections;
using UnityEngine;

public class AppearingLooking : MonoBehaviour
{
    //wait how do you make it so that this cant start if there are 50 seconds or less on the timer?

    public float standingTime = Random.Range(10.0f, 30.0f);

    //gap # (not sure how to make it so that a customer cant appear at one gap if theres already a customer at another gap
    public int gapNumber = Random.Range(1, 2);

    //not looking by default
    public bool looking = false;


    private void Start()
    {
        StartCoroutine(PlayWalkingInAnimation());
    }

    private void Update()
    {
        //runs timer
        standingTime -= Time.deltaTime;

        //6 percent chance every second to trigger the looking
        if (standingTime % 1 == 0.0f)
        {
            int chance = Random.Range(1, 100);
            if(chance <= 6)
            {
                looking = true;
            }
        }

        //looking mechanic if the character is looking
        if(looking == true)
        {
            StartCoroutine(PlayTurningAnimation());
            //wait also how do you access the sus bar
            //if statement that says if the player's position is at the gap generated then the sus bar goes up
            //also how do you make it so that the looking animation is at the same time as that happening?
            looking = false;
        }

        //leaving
        if(standingTime <= 0.0f)
        {
            StartCoroutine(PlayWalkingOutAnimation());
        }
    }

    //animation enums
    IEnumerator PlayWalkingInAnimation()
    {
       //Animator.Play(animationName); (walking in animation)
        yield return new WaitForSeconds(2.0f);
        Debug.Log("walking in animation");
    }
    IEnumerator PlayTurningAnimation()
    {
        //Animator.Play(turningAnim); (turning animation with warning)
        yield return new WaitForSeconds(2.0f);
        Debug.Log("turning animation");
    }
    IEnumerator Looking()
    {
        float lookTime = Random.Range(2.0f, 6.0f);
        //how do i get it so that the looking animation is at the same time as sus bar going up?
        yield return new WaitForSeconds(lookTime);
        Debug.Log("looking animation");
    }
    IEnumerator PlayWalkingOutAnimation()
    {
        //Animator.Play(otherAnimationName); (walking out animation)
        yield return new WaitForSeconds(2.0f);
        Debug.Log("walking out animation");
    }
}
