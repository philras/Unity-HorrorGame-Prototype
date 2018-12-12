using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitchTrigger : MonoBehaviour {
    public string scene;

	public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel(scene);
        }
    }
}
