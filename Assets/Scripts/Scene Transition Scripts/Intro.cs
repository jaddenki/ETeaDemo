using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    public CanvasGroup uiCanvasGroup;
    public float fadeDuration = 7f;
    public Sprite[] frames;
    public SpriteRenderer anime;
    public float fR = 0.4f; // framerate
    
    void Start()
    {
        StartCoroutine(StartAnimation());
        StartCoroutine(FadeOutCanvasGroup(uiCanvasGroup, fadeDuration));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
    private IEnumerator StartAnimation()
    {
        foreach (var frame in frames)
        {
            anime.sprite = frame;
            yield return new WaitForSeconds(fR);
        }

    }

    private IEnumerator FadeOutCanvasGroup(CanvasGroup canvasGroup, float duration)
    {
        float startAlpha = canvasGroup.alpha;
        float time = 0;
        yield return new WaitForSeconds(5f);
        while (time < duration)
        {
            time += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, 0, time / duration);
            yield return null;
        }

        // Ensure the final alpha is set to 0
        canvasGroup.alpha = 0;
    }
}
