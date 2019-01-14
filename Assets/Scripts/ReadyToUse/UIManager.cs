using UnityEngine;
using UnityEngine.UI;

namespace ReadyToUse
{
    public class UIManager : MonoBehaviour
    {
        public Text Score;
        public Text BestScore;

        private void Awake()
        {
            EventsManager.ScoreUpdated += OnScoreUpdated;
        }

        private void OnScoreUpdated(int score, int bestScore)
        {
            Score.text = score.ToString();
            BestScore.text = bestScore.ToString();
        }
    }
}