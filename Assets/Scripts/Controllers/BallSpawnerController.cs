using UnityEngine;

namespace Controllers {
    public class BallSpawnerController : MonoBehaviour {
        private Transform ballSpawnerTransform;
        [SerializeField] private GameObject ballPrefab = default;
        [SerializeField] private Transform ballsParent = default;
        [SerializeField] private float spawnForceModifier = 1f;

        private void Awake() {
            ballSpawnerTransform = transform;
        }

        public void SpawnBall() {
            GameObject spawnedBall =
                Instantiate(ballPrefab, ballSpawnerTransform.position, Quaternion.identity, ballsParent);
            spawnedBall.GetComponent<Rigidbody>().AddForce(ballSpawnerTransform.forward * spawnForceModifier);
        }
    }
}