using UnityEngine;

public class MeteorMovement : MonoBehaviour
{

    public Vector2 speed;
    Vector2 moveY = new Vector3(0f, -1f, 0f);
    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.activeSelf == true)
        {
            Vector3 movement = Vector2.down * speed;
            movement *= Time.deltaTime;
            transform.Translate(movement);
        }
        

    }
}
