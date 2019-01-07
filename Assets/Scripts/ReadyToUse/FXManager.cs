using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReadyToUse
{
    public static class FXManager
    {
        private static GameObject toyHitFXPrefab;

        public static void Initialize()
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
