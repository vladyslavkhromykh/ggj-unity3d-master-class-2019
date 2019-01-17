using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private float timer;

    private void Awake()
    {
        gameObject.hideFlags = HideFlags.HideInHierarchy;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5.0f)
        {
            Destroy(gameObject);
        }
    }
}
