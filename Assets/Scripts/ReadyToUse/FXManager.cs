using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReadyToUse
{
    public class FXManager : MonoBehaviour
    {
        private static GameObject toyHitFXPrefab;

        private void Awake()
        {
            toyHitFXPrefab = Resources.Load<GameObject>("FX/toyHitFX");
            EventsManager.BulletHitToy += OnBulletHitToy;
        }

        private static void OnBulletHitToy(Toy toy)
        {
            Vector3 toyPosition = toy.transform.position;
            GameObject toyHitFX = GameObject.Instantiate<GameObject>(toyHitFXPrefab);
            toyHitFX.transform.position = toyPosition;
        }
    }

}
