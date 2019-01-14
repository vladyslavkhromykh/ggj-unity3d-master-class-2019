using UnityEngine;

namespace ReadyToUse {
    public class Toy : MonoBehaviour
    {
        [Range(20.0f, 100.0f)]
        public float LifeTimeLimit;
        public bool isGrounded
        {
            get;
            private set;
        }
        private float lifeTime;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
                isGrounded = true;
            }

            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Bullet"))
            {
                EventsManager.OnBulletHitToy(this);
                Destroy(gameObject);
                Destroy(collision.collider.gameObject);
            }
        }

        private void Update()
        {
            CheckLifeTime();
        }

        private void CheckLifeTime()
        {
            lifeTime += Time.deltaTime;
            if (lifeTime > LifeTimeLimit)
            {
                Destroy(gameObject);
            }
        }
    }

}
