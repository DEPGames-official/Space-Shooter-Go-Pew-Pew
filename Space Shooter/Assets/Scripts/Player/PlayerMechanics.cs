using System;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{

    public Collider2D meteorCollider;

    //public Vector3 offset;

    public ProjectileBehaviour projectilePrefab;
    public Transform launchOffset;

    
    
    // Update is called once per frame
    void Update()
    {

        //gun = Physics2D.Raycast(transform.position + offset, Vector2.up);
        ShootGun();
        print(projectilePrefab.collided.transform.tag);
    }

    

    void ShootGun()
    {
        try
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(projectilePrefab, launchOffset.position, transform.rotation);
            }
            //print($"{projectilePrefab.collided.transform.tag} + " + $" {meteorCollider.tag}");

            if (projectilePrefab.collided.transform.tag == "Meteor")
            {
                
                var scriptHealth = projectilePrefab.transform.GetComponent<MeteorHealth>();

                print("SHOT");
                scriptHealth.health -= 25;

                print(scriptHealth.health);
            }
            else
            {
                //print("not Meteor");
            }
        }
        catch (NullReferenceException e) {print(e.Message); }
        
    }
}
