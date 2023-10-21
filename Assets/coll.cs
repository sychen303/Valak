using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

 
}
