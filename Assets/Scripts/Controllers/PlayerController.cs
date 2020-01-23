using UnityEngine;

namespace Controllers {
    public class PlayerController : MonoBehaviour {
        [SerializeField] private float mouseSensitivity = 1f;
        private float yawn = 0.0f;
        private float pitch = 0.0f;

        [SerializeField] private float speed = 1f;
        [SerializeField] private BallSpawnerController ballSpawnerController = default;
        private Transform playerTransform;

        private void Awake() {
            playerTransform = transform;
            yawn = 0.0f;
            pitch = 0.0f;
        }

        private void Update() {
            Vector3 currentPosition = playerTransform.position;
            playerTransform.position = new Vector3(
                currentPosition.x + Input.GetAxis("Horizontal") * speed,
                currentPosition.y,
                currentPosition.z + Input.GetAxis("Vertical") * speed);

            yawn += Input.GetAxis("Mouse X") * mouseSensitivity;
            pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
            if (pitch < -90f) pitch = -90f;
            else if (pitch > 90f) pitch = 90f;
            transform.eulerAngles = new Vector3(pitch, yawn, 0f);

            if (Input.GetKeyUp("space"))
                ballSpawnerController.SpawnBall();
        }
    }
}