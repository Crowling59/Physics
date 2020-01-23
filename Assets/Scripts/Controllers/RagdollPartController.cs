using UnityEngine;

namespace Controllers {
    public class RagdollPartController : MonoBehaviour {
        private static LayerMask ballLayer;

        private void Awake() {
            ballLayer = LayerMask.NameToLayer("Ball");
        }

        private void OnCollisionEnter(Collision other) {
            if (other.gameObject.layer == ballLayer)
                Destroy(gameObject);
        }
    }
}