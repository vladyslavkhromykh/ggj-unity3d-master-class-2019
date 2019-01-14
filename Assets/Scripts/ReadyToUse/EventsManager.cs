using System;
using UnityEngine;

namespace ReadyToUse
{
    public static class EventsManager
    {
        public static event Action PlayerShot = delegate { };
        public static event Action<Toy> BulletHitToy = delegate { };
        public static event Action ToySpawn = delegate { };
        public static event Action<int, int> ScoreUpdated;

        public static void OnPlayerShot()
        {
            PlayerShot();
        }

        public static void OnBulletHitToy(Toy toy)
        {
            BulletHitToy(toy);
        }

        public static void OnToySpawn()
        {
            ToySpawn();
        }

        public static void OnScoreUpdated(int score, int bestScore)
        {
            ScoreUpdated(score, bestScore);
        }
    }

}
