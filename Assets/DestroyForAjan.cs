using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyForAjan : MonoBehaviour
{

    private int healt = 3;


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("ajan"))
        {
            if (healt != 0)
            {
                healt--;
            }
            else
            {
                Destroy(gameObject);
            }
        }
       
    }

}
