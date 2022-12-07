using UnityEngine;

public class Spawner : MonoBehaviour
{
    public void Spawn(GameObject spawnObject, Vector3 spawnPosition, Quaternion spawnRotation)
    {
        GameObject clones = Instantiate(spawnObject, spawnPosition, spawnRotation);
        //var parent = new GameObject($"{spawnObject.name} Clones");

    }
}
