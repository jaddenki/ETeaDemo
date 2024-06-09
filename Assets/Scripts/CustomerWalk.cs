using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerWalk : MonoBehaviour
{
     public SpriteRenderer anim;

    // customer animations
    public Sprite[] cust1;
    public Sprite[] cust2;
    public Sprite[] cust3;
    public Sprite[] cust4;
    public Sprite[] cust5;

    // interval to trigger animations
    public float minInterval = 4.0f;
    public float maxInterval = 6.0f;

    public float frameInterval = 0.2f; // 200 ms
    private int cf; // current frame

        void Start()
    {
        if (anim == null)
        {
            anim = GetComponent<SpriteRenderer>();
        }

        // Start the coroutine to handle random animation triggering
        StartCoroutine(WaitBeforeAnimation());
   
    }

    private IEnumerator WaitBeforeAnimation()
    {
        yield return new WaitForSeconds(8f); // lets wait this long before we actually start animation 
    }


}
