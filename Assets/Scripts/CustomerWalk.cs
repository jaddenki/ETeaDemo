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
    public float fISmall = 0.1f;
    private int cf; // current frame
    private int cfw; // current frame for warning animations
    private bool DoIStart;

    // warning animations
    public SpriteRenderer warning;
    public Sprite[] warningImg;
    public SpriteRenderer found;
    public Sprite[] foundImg;
    public GameObject warningObj;
    public GameObject foundObj;

        void Start()
    {
        if (anim == null)
        {
            anim = GetComponent<SpriteRenderer>();
        }
        foundObj.SetActive(false);
        warningObj.SetActive(false);
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
            if((cf == 13) || (cf == 28) || (cf == 55) || (cf == 70))
            {
                Debug.Log("Hoh hoh imma check");
                StartCoroutine(WarningAnimation());
                //yield return new WaitForSeconds(fISmall * 4);
            }


            // cust is checking
            if ((cf == 18) || (cf == 33) || (cf == 60) || (cf == 75))
            {
                DoIStart = sussy.IsSussy();

                if (DoIStart)
                {
                    StartCoroutine(FoundAnimation());
                    //yield return new WaitForSeconds(fISmall * 4);
                }
            }
        anim.sprite = chosenAnim[cf];
        cf++;
        yield return new WaitForSeconds(frameInterval);
        }
        anim.sprite = Clear;
    }

    private IEnumerator WarningAnimation()
    {
        warningObj.SetActive(true);
        Debug.Log("warning animation");
        cfw = 0;
        while (cfw < warningImg.Length)
        {
        warning.sprite = warningImg[cfw];
        cfw++;
        yield return new WaitForSeconds(fISmall);
        }
        warning.sprite = Clear;
        warningObj.SetActive(false);
    }

    private IEnumerator FoundAnimation()
    {
        Debug.Log("Found animation");
        foundObj.SetActive(true);
        cfw = 0;
        while (cfw < foundImg.Length)
        {
        found.sprite = foundImg[cfw];
        cfw++;
        yield return new WaitForSeconds(fISmall);
        }
        found.sprite = Clear;
        foundObj.SetActive(false);
    }

}
