using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject lifeBar;
    private HealthSystem healthSystem;
    public void Setup(HealthSystem healthSystem) {
        this.healthSystem = healthSystem;

        //healthSystem.OnHealthChanged = HealthSystem_OnHealthChanged;
    }
    public void HealthSystem_OnHealthChanged ()
    { 
      lifeBar.transform.localScale = new Vector3(healthSystem.GetHealthPercent(), 1, 1);
    }
}
