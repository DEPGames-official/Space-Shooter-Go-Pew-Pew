using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Spawn(GameObject spawnObject, Vector3 spawnPosition, Quaternion spawnRotation)
    {
        GameObject clones = Instantiate(spawnObject, spawnPosition, spawnRotation);
        //var parent = new GameObject($"{spawnObject.name} Clones");
        return clones;
    }
}
