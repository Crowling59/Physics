using UnityEngine;

namespace Controllers {
    public class PlayerController : MonoBehaviour {
        private Transform playerTransform;

        private void Awake() {
            playerTransform = transform;
        }

        private void Update() {
            Vector3 currentPosition = playerTransform.position;
            playerTransform.position = new Vector3(
                currentPosition.x + Input.GetAxis("Horizontal"),
                currentPosition.y,
                currentPosition.z + Input.GetAxis("Vertical"));
        }
    }
}