using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var scriptHealth = collision.gameObject.GetComponent<MeteorHealth>();
        scriptHealth.health -= 25;

        Destroy(gameObject);
    }
}
