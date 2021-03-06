using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private void Update()
    {
        float dt = Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * dt * speed);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * dt * speed);
        }

        else if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * dt * speed);
        }
        
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * dt * speed);
        }
    }
}
