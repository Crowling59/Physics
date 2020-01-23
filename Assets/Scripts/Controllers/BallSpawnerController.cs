using UnityEngine;

namespace Controllers {
    public class BallSpawnerController : MonoBehaviour {
        private Transform ballSpawnerTransform;
        [SerializeField] private GameObject ballPrefab = default;
        [SerializeField] private Transform ballsParent = default;

        private void Awake() {
            ballSpawnerTransform = transform;
        }

        public void SpawnBall() {
            Instantiate(ballPrefab, ballSpawnerTransform.position, Quaternion.identity, ballsParent);
        }
    }
}