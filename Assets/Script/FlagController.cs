using UnityEngine;

public class FlagController : MonoBehaviour
{
    public float amplitude = 0.5f; // Biên độ chuyển động của cờ
    public float frequency = 1f; // Tần số chuyển động của cờ

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
