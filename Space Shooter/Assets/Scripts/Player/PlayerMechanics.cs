using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    public ProjectileBehaviour projectilePrefab;
    public Transform launchOffset;

    void Update()
    {
        ShootGun();
    }



    void ShootGun()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectilePrefab, launchOffset.position, transform.rotation);
        }
    }
}
