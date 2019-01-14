using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReadyToUse
{
    public class ScoresManager : MonoBehaviour
    {
        public int Score
        {
            get;
            private set;
        }

        private void Awake()
        {
            EventsManager.BulletHitToy += OnBulletHitToy;
        }

        private void OnBulletHitToy(Toy toy)
        {
            Score++;

            int bestScore = PlayerPrefs.GetInt("best-score", 0);
            if (Score > bestScore)
            {
                bestScore = Score;
                PlayerPrefs.SetInt("total-score", Score);
            }

            PlayerPrefs.Save();
        }
    }
}