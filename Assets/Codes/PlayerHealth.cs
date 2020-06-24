using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //public Transform pfHealthBar;
    public HealthBar healthBar;
    HealthSystem healthSystem;
    void Start()
    {
        healthSystem = new HealthSystem(100);
        //Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0, 10), Quaternion.identity);
        //HealthBar pfhealthBar = healthBarTransform.GetComponent<HealthBar>();
        healthBar.Setup(healthSystem);
        healthSystem.SetHealth(70);
    }
    void Update()
    {
        healthBar.HealthSystem_OnHealthChanged();
        //healthSystem.OnHealthChanged();
    }
}
