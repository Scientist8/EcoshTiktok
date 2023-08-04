using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfAutoDestruct : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] float timeToSelfDestruct;
    
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToSelfDestruct)
        {
            Destroy(this.gameObject);
        }
    }
}
