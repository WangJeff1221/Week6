using UnityEngine;

public class BoatController : MonoBehaviour
{
    public float speed = 5f; 

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");

        Vector3 movement = new Vector3(move * speed * Time.deltaTime, 0, 0);

        transform.Translate(movement);
    }
}
