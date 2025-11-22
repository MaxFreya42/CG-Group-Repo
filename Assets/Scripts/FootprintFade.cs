using UnityEngine;

public class FootprintFade : MonoBehaviour
{
    public float lifeTime = 5f;        // total time before disappearing
    public float fadeTime = 2f;        // fade during the last X seconds

    private float timer;
    private SpriteRenderer sr;
    private Vector3 initialScale;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        initialScale = transform.localScale;
        timer = lifeTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        // Start fading & shrinking during the fadeTime
        if (timer < fadeTime)
        {
            float t = timer / fadeTime;

            // Fade alpha
            Color c = sr.color;
            c.a = Mathf.Lerp(0, 1, t);
            sr.color = c;

            // Shrink
            transform.localScale = initialScale * t;
        }

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}