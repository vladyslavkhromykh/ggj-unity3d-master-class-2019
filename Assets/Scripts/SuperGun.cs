using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ReadyToUse;

public class SuperGun : MonoBehaviour
{
    private GameObject bulletPrefab;

    private void Awake()
    {
        bulletPrefab = Resources.Load<GameObject>("Presentation/Bullet");
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            EventsManager.OnPlayerShot();
            GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward * 3.0f, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 50.0f, ForceMode.Impulse);
        }
    }
}
