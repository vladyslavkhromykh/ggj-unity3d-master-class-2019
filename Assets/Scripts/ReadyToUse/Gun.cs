using UnityEngine;

namespace ReadyToUse
{
    public class Gun : MonoBehaviour
    {
        [Range(5.0f, 200.0f)]
        public float ShootForce;
        private GameObject bulletPrefab;

        private void Awake()
        {
            bulletPrefab = Resources.Load<GameObject>("Bullets/bullet");
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            GameObject bullet = Instantiate<GameObject>(bulletPrefab);
            bullet.transform.position = transform.position + transform.forward * 2.0f;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * ShootForce, ForceMode.Impulse);
            EventsManager.OnPlayerShot();
        }
    }
}
