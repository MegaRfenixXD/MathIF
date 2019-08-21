using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnItem : MonoBehaviour
{
    private Rigidbody respawn;
 
    void Start()
    {
        respawn = GetComponent<Rigidbody>();
    }



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ABISMO" && this.gameObject.name == "BolaChave")
        {
            respawn.position = new Vector3(-0.416f, 0.064f, 8.082f);
            respawn.velocity = new Vector3(0, 0, 0);
            
        }

        if (col.gameObject.name == "ABISMO" && this.gameObject.name == "BolaChave")
        {
            respawn.position = new Vector3(-0.416f, 0.064f, 8.082f);
            respawn.velocity = new Vector3(0, 0, 0);

        }
    }
}
