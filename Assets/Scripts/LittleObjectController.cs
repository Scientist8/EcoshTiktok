using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleObjectController : MonoBehaviour
{
    public float speed = 10f;

    //===================================================================================

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    //===================================================================================

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
