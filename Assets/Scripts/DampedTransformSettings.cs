using UnityEngine;

[CreateAssetMenu(fileName = "Settings")]
public class DampedTransformSettings : ScriptableObject
{
    [SerializeField, Range(0.001f, 0.05f)] float waviness = .02f;
    [SerializeField, Range(0f, .9f)] float speed = .8f;
    [SerializeField] Vector3 offset = Vector3.zero;
    [SerializeField] AimStatus alongX;
    [SerializeField] AimStatus alongY;
    [SerializeField] AimStatus alongZ;

    public float Waviness { get => waviness; }
    public float Speed { get => speed; }
    public Vector3 Offset { get => offset; }
    public AimStatus AlongX { get => alongX; }
    public AimStatus AlongY { get => alongY; }
    public AimStatus AlongZ { get => alongZ; }
}
