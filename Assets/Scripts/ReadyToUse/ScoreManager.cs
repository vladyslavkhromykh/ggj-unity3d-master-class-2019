using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReadyToUse
{
    public class ScoreManager : MonoBehaviour
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

        private void Start()
        {
            EventsManager.OnScoreUpdated(Score, PlayerPrefs.GetInt("best-score", 0));
        }

        private void OnBulletHitToy(Toy toy)
        {
            int pointsToAdd = 0;
            if (toy.isGrounded)
            {
                pointsToAdd = 5;
            } else
            {
                pointsToAdd = 100;
            }

            Score += pointsToAdd;

            int bestScore = PlayerPrefs.GetInt("best-score", 0);
            if (Score > bestScore)
            {
                bestScore = Score;
                PlayerPrefs.SetInt("best-score", Score);
            }

            EventsManager.OnScoreUpdated(Score, bestScore);
            PlayerPrefs.Save();
        }
    }
}