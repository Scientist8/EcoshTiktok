using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // ==================================================================================

    // 1 tane ozel enemy oldugu icin singleton cakiyom yine bunu

    public static EnemyController Instance { get; private set; }

    // ==================================================================================

    public float maxHealth;
    public float currentHealth = 99999;

    // ==================================================================================


    //===================================================================================

    void Awake()
    {
        SingletonThisObject();
    }

    void SingletonThisObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    //===================================================================================

    void Start()
    {
        maxHealth = currentHealth;
    }

    //===================================================================================

    void Update()
    {
        
    }

    //===================================================================================

    public void HealthChange(float changeAmount)
    {
        currentHealth -= changeAmount;

        // Health bar degerleri bu asagida degisiyor
        UIManager.Instance.HealthChange();
    }
}
