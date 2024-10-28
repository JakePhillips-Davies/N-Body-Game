using UnityEngine;

public class SunlightController : MonoBehaviour
{
    private float intensity;
    [SerializeField] private float sunPower;
    [SerializeField] private new Light light;
    void FixedUpdate()
    {
        Transform cam = Camera.main.transform;

        transform.LookAt(cam.position);

        intensity = sunPower / ((cam.position - transform.position).magnitude / 1000);

        light.intensity = intensity;
    }
}
