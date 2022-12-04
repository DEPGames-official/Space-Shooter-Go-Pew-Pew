using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    public float Health = 100;
    public MeteorMechanics meteorScript;

    // Start is called before the first frame update
    void Start()
    {
               
    }

    public Vector3 offset;
    public RaycastHit2D gun;
    // Update is called once per frame
    void Update()
    {
        gun = Physics2D.Raycast(transform.position + offset, Vector2.up);
        ShootGun();
    }

    public Collider2D meteorCollider;
    void ShootGun()
    {
        try
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                print(gun.collider);
                if (gun.collider.tag == meteorCollider.tag)
                {
                    var scriptHealth = gun.collider.GetComponent<MeteorMechanics>();
                    print("SHOT");
                    scriptHealth.health -= 25;
                    print(scriptHealth.health);
                }
                else
                {
                    print("not Meteor");
                }
            }
        }
        catch(System.NullReferenceException) { }
    }
}
