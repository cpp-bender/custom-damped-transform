using UnityEngine;

public class DampedTransform : MonoBehaviour
{
    public DampedTransformSettings settings;
    public GameObject target;

    private Vector3 velocity = Vector3.zero;

    private void Update()
    {
        float dt = Time.deltaTime;

        Vector3 f = transform.position - target.transform.position - settings.Offset;

        f = new Vector3((int)settings.AlongX * f.x, (int)settings.AlongY * f.y, (int)settings.AlongZ * f.z);

        velocity += -settings.Waviness / dt * f;

        velocity *= settings.Speed;

        transform.position += velocity * dt;
    }
}
