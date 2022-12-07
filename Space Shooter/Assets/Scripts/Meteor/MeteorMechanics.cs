using UnityEngine;

public class MeteorMechanics : MonoBehaviour
{
    Spawner spawnMeteors;


    public GameObject meteor;
    public Vector3 meteorPosition;
    public Quaternion meteorRotation;


    // Start is called before the first frame update
    void Start()
    {
        spawnMeteors = gameObject.AddComponent<Spawner>();

        for (int i = 0; i < 1; i++)
        {
            System.Random randomXPosition = new System.Random();
            int randomX = randomXPosition.Next(-10, 6);
            meteorPosition = new Vector3(randomX, 6, 0);


            spawnMeteors.Spawn(meteor, meteorPosition, meteorRotation);
        }
    }
}
