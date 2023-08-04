using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleObjectSpawner : MonoBehaviour
{
    // Askit burada 0 inci element spawn olunca sifirinci damage degerini aliyor enemy health i.
    // Ayni sekil ilerleterek sen de yeni fonksiyon ekleyebilirsin
    // objectsToSpawn icine prefab aliyor, damageAmounts float degeri

    public List<GameObject> objectsToSpawn;
    public float[] damageAmounts;

    //===================================================================================

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            Spawn0();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Spawn1();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Spawn2();
        }
    }

    //===================================================================================

    void Spawn0()
    {
        GameObject go = Instantiate(objectsToSpawn[0], transform.position, Quaternion.identity);
        go.transform.position += Vector3.right * Random.Range(-2, 2);

        EnemyController.Instance.HealthChange(damageAmounts[0]);
    }

    //===================================================================================

    void Spawn1()
    {
        GameObject go = Instantiate(objectsToSpawn[1], transform.position, Quaternion.identity);
        go.transform.position += Vector3.right * Random.Range(-2, 2);

        EnemyController.Instance.HealthChange(damageAmounts[1]);
    }

    //===================================================================================
    void Spawn2()
    {
        GameObject go = Instantiate(objectsToSpawn[2], transform.position, Quaternion.identity);
        go.transform.position += Vector3.right * Random.Range(-2, 2);

        EnemyController.Instance.HealthChange(damageAmounts[2]);
    }
}
