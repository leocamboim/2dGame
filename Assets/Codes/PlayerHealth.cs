using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject deathFXPrefab;

    bool isAlive = true;
    int trapsLayer;
    // Start is called before the first frame update
    void Start()
    {
        trapsLayer = LayerMask.NameToLayer("Traps");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != trapsLayer || !isAlive)
            return;

        isAlive = false;

        Instantiate(deathFXPrefab, transform.position, transform.rotation);

        gameObject.SetActive(false);

        //GameManeger.PlayerDied();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
