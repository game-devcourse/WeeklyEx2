using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [Tooltip("The maximum scale of the ball during inflation")]
    [SerializeField] Vector3 maxScale = new Vector3(1.5f, 1.5f, 1.5f);

    [Tooltip("Duration of each beat in seconds")]
    [SerializeField] float beatDuration = 1.0f;

    // Update is called once per frame
    void Update()
    {
        float scaleMultiplier = 1.0f + Mathf.PingPong(Time.time / beatDuration, 1.0f);
        transform.localScale = Vector3.Scale(maxScale, new Vector3(scaleMultiplier, scaleMultiplier, scaleMultiplier));
    }
}
