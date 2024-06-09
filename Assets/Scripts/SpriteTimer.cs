using UnityEngine;
using System.Collections;

public class SpriteTimer : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public float changeInterval = 1.0f;
    private int currentSpriteIndex = 0;
    private Coroutine spriteCoroutine;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnEnable()
    {

        currentSpriteIndex = 0;

        spriteCoroutine = StartCoroutine(ChangeSpriteRoutine());
    }

    void OnDisable()
    {
     
        if (spriteCoroutine != null)
        {
            StopCoroutine(spriteCoroutine);
        }
    }

    IEnumerator ChangeSpriteRoutine()
    {
        while (true)
        {
     
            yield return new WaitForSeconds(changeInterval);

 
            currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
            spriteRenderer.sprite = sprites[currentSpriteIndex];
        }
    }
}
