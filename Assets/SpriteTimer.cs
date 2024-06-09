using UnityEngine;
using System.Collections;

public class SpriteTimer : MonoBehaviour
{
    public Sprite[] sprites; // Array to hold your sprites
    private SpriteRenderer spriteRenderer;
    public float changeInterval = 1.0f; // Time in seconds between sprite changes
    private int currentSpriteIndex = 0;
    private Coroutine spriteCoroutine;

    void Awake()
    {
        // Get the SpriteRenderer component attached to this GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnEnable()
    {
        // Ensure the sprites array is properly set
        if (sprites.Length == 0)
        {
            Debug.LogError("No sprites assigned to the sprites array!");
            return;
        }

        // Reset the sprite index to start from the beginning
        currentSpriteIndex = 0;

        // Start the coroutine that changes the sprite every second
        spriteCoroutine = StartCoroutine(ChangeSpriteRoutine());
    }

    void OnDisable()
    {
        // Stop the coroutine when the GameObject is disabled
        if (spriteCoroutine != null)
        {
            StopCoroutine(spriteCoroutine);
        }
    }

    IEnumerator ChangeSpriteRoutine()
    {
        while (true)
        {
            // Wait for the specified interval
            yield return new WaitForSeconds(changeInterval);

            // Change to the next sprite in the array
            currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
            spriteRenderer.sprite = sprites[currentSpriteIndex];
        }
    }
}
