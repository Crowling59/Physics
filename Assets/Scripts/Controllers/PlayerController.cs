using UnityEngine;

namespace Controllers {
    public class PlayerController : MonoBehaviour {
        [SerializeField] private float speed = 1f;
        [SerializeField] private BallSpawnerController ballSpawnerController = default;
        private Transform playerTransform;

        private void Awake() {
            playerTransform = transform;
        }

        private void Update() {
            Vector3 currentPosition = playerTransform.position;
            playerTransform.position = new Vector3(
                currentPosition.x + Input.GetAxis("Horizontal") * speed,
                currentPosition.y,
                currentPosition.z + Input.GetAxis("Vertical") * speed);

            if (Input.GetKeyUp("space"))
                ballSpawnerController.SpawnBall();
        }
    }
}