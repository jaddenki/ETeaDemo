using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CustomerWalk : MonoBehaviour
{
     public SpriteRenderer anim;
     public Sprite Clear;
     public Sussy sussy;

    // customer animations
    public Sprite[] cust1;
    public Sprite[] cust2;
    public Sprite[] cust3;
    public Sprite[] cust4;
    public Sprite[] cust5;

    // time interval to trigger animations
    public float minInterval = 4.0f;
    public float maxInterval = 6.0f;

    public float frameInterval = .2f; // 200 ms
    private int cf; // current frame

        void Start()
    {
        if (anim == null)
        {
            anim = GetComponent<SpriteRenderer>();
        }

        // lets wait!!! let the alien chil!!!
        StartCoroutine(WaitBeforeAnimation());
        StartCoroutine(ChooseAnimation());


   
    }

    private IEnumerator WaitBeforeAnimation()
    {
        yield return new WaitForSeconds(2f); // lets wait this long before we actually start animation 
    }

    private IEnumerator ChooseAnimation()
    {
        while (true)
        {
            // wait for a set amount of time
            float waitTime = Random.Range(minInterval, maxInterval);
            yield return new WaitForSeconds(waitTime);

            // randomly choose an a character animation to play..
            int randomAnimationIndex = Random.Range(0, 4);
            Sprite[] selectedAnimation;
            // im about to choose which animation
            switch (randomAnimationIndex)
            {
                case 0:
                    selectedAnimation = cust1;
                    break;
                case 1:
                    selectedAnimation = cust2;
                    break;
                case 2:
                    selectedAnimation = cust3;
                    break;
                case 3:
                    selectedAnimation = cust4;
                    break;
                default:
                    selectedAnimation = cust1; // default ahh
                    break;
            }

            yield return StartCoroutine(Walk(selectedAnimation));
        
        }

    }
    private IEnumerator Walk(Sprite[] chosenAnim)
    {
        Debug.Log("Starting Animation");
        cf = 0;
        while (cf < chosenAnim.Length)
        {
            // warning that cust gonna check. this is where u wanna pput the warning sign animation
            if((cf == 18) || (cf == 28) || (cf == 65) || (cf == 70))
            {
                Debug.Log("Hoh hoh imma check");
            }
            // cust is checking
            if ((cf == 18) || (cf == 33) || (cf == 60) || (cf == 75))
            {
                sussy.IsSussy();
            }
        anim.sprite = chosenAnim[cf];
        cf++;
        yield return new WaitForSeconds(frameInterval);
        }
        anim.sprite = Clear;
    }

}
