using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {

    private void OnTriggerStay(Collider other) {
        Debug.Log(other.name);
        if(other.gameObject.tag == "Player") {
            other.gameObject.transform.position += Vector3.up * Time.deltaTime * 5;
        }
    }
}
