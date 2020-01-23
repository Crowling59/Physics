using System.Collections;
using UnityEngine;

namespace Controllers {
    public class RagdollSpawnController : MonoBehaviour {
        [SerializeField] private Transform ragdollsParent = default;
        [SerializeField] private BoxCollider spawnZone = default;
        [SerializeField] private GameObject ragdollPrefab = default;
        private Bounds spawnBounds;

        private void Awake() {
            spawnBounds = spawnZone.bounds;
            StartCoroutine(DoSpawns());
        }

        private IEnumerator DoSpawns() {
            while (true) {
                yield return new WaitForSeconds(2f);
                Instantiate(ragdollPrefab, GetRandomSpawnPosition(), Quaternion.identity, ragdollsParent);
            }
        }

        private Vector3 GetRandomSpawnPosition() {
            return new Vector3(
                Random.Range(spawnBounds.min.x, spawnBounds.max.x),
                Random.Range(spawnBounds.min.y, spawnBounds.max.y),
                Random.Range(spawnBounds.min.z, spawnBounds.max.z));
        }
    }
}