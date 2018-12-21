using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    [SerializeField] private GameObject Cube;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            other.GetComponent<fl_PlayerMovement>().canMove = false;
            Cube.SetActive(true);
            Cube.GetComponent<Animator>().SetTrigger("Finish");
        }
    }

}
