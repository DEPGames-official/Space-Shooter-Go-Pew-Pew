using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    public float Health = 100;

    // Start is called before the first frame update
    void Start()
    {
               
    }

    public Vector3 offset= new Vector3(0, 5, 0);
    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D gun = Physics2D.Raycast(transform.position + offset, Vector2.up);
        print(gun.collider);
    }
}
