using System.Collections;
using UnityEngine;

namespace Controllers {
    public class RagdollController : MonoBehaviour {
        private Rigidbody ragdollRigidbody;
        [SerializeField] private float speedModifier = 0.01f;

        private void Awake() {
            ragdollRigidbody = GetComponent<Rigidbody>();
            StartCoroutine(DoMovements());
        }

        private IEnumerator DoMovements() {
            while (true) {
                float timeToDoMovement = Random.Range(2f, 5f);
                float timer = 0f;
                Vector3 deltaPosition = new Vector3(Random.Range(-1f, 1f),
                                            Random.Range(-0.1f, 0.1f),
                                            Random.Range(-1f, 1f)) * speedModifier;

                while (timer < timeToDoMovement) {
                    timer += Time.deltaTime;
                    ragdollRigidbody.position += deltaPosition;
                    yield return new WaitForEndOfFrame();
                }
            }
        }
    }
}