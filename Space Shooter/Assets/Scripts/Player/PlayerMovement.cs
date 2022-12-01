using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {
         speed = new Vector2(20, 20);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(inputX * speed.x, inputY * speed.y, 0);
        movement *= Time.deltaTime;

        this.transform.Translate(movement);

    }
}
