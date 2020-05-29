using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //public Transform pfHealthBar;
    public HealthBar healthBar;
    void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);

        //Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0, 10), Quaternion.identity);
        //HealthBar pfhealthBar = healthBarTransform.GetComponent<HealthBar>();
        healthBar.Setup(healthSystem);

    }
}
