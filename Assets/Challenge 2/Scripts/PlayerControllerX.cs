using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float delayDog = 0;

    // Update is called once per frame
    void Update()
    {
        delayDog += Time.deltaTime;
        if (delayDog > 0.5f)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

                delayDog = 0;
            }
        }
    }
}
