using UnityEngine;

namespace Controllers {
    public class TriggerController : MonoBehaviour {
        [SerializeField] private RagdollSpawnController ragdollSpawnController = default;

        private void OnTriggerEnter(Collider other) {
            ragdollSpawnController.StartSpawning();
        }
    }
}