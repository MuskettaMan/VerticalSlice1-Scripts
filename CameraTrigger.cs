using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

    [SerializeField] GameObject playerCamera;

    [SerializeField] CameraTriggers cameraTriggers;

    private void Start() {
        playerCamera.SetActive(cameraTriggers.Active);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            cameraTriggers.Active = !cameraTriggers.Active;
            playerCamera.SetActive(cameraTriggers.Active);
        }
    }

}
