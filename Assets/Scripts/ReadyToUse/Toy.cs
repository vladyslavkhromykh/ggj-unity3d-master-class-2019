using UnityEngine;

namespace ReadyToUse {
    public class Toy : MonoBehaviour
    {
        public bool isGrounded;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Bullet"))
            {
                EventsManager.OnBulletHitToy(this);
                Destroy(gameObject);
                Destroy(collision.collider.gameObject);
            }

            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
                isGrounded = true;
            }
        }

    }

}
