using UnityEngine;

public class Shake : MonoBehaviour
{
    public float shakeDuration = 7;
    public float shakeMagnitude = 1f;
    public Vector3 originalPosition;
    private float shakeTime = 0f;

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        // Llama a la sacudida al presionar un botón (opcional para pruebas)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TriggerShake();
        }

        if (shakeTime > 0)
        {
            transform.localPosition = originalPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeTime -= Time.deltaTime;
        }
        else
        {
            shakeTime = 0;
            transform.localPosition = originalPosition; 
        }
    }

    public void TriggerShake()
    {
        shakeTime = shakeDuration; 
    }
}
