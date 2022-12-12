using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed;
    public Collision2D collided;

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collided = collision;
        //print(collided.transform.tag);
        //Destroy(gameObject);
    }
}
