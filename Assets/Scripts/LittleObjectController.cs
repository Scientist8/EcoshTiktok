using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleObjectController : MonoBehaviour
{
    [SerializeField] GameObject deathParticle;
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
            GameObject go = Instantiate(deathParticle, transform.position, Quaternion.identity);
            go.transform.Rotate( new Vector3(-90, 0, 0));
            Destroy(this.gameObject);
        }
    }
}
