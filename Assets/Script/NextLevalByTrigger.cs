using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevalByTrigger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger game over")]
    [SerializeField] string triggeringTag;
    [SerializeField] string nextlevalName;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
                Debug.Log("NextLevalByTrigger!");
                SceneManager.LoadScene(nextlevalName);
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }

}
