using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlateforms : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Border"){

            Destroy(this.gameObject);

        }

    }

}
