using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    //===================================================================================

    // UI manager'i singleton yapiyom
    public static UIManager Instance { get; private set; }

    //===================================================================================

    // Burada event var oskit, bunu health bar UI'i icin kullanacaz

    public delegate void OnHealthChangeDelegate();
    public event OnHealthChangeDelegate OnHealthChanged;


    //===================================================================================

    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text healthText;

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
        healthText.text = EnemyController.Instance.currentHealth.ToString();
    }

    //===================================================================================

    public void HealthChange()
    {
        healthText.text = EnemyController.Instance.currentHealth.ToString();
        healthBar.fillAmount = EnemyController.Instance.currentHealth / EnemyController.Instance.maxHealth;

        OnHealthChanged?.Invoke();
    }
}
