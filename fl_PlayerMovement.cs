using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fl_PlayerMovement : MonoBehaviour {

    public bool canMove = true;

	// Use this for initialization
	void Start () {
        MovementSpeed = 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
        if(canMove) {
            CheckInput();
        }
        
    }

    private void CheckInput() {
        

        if(Input.GetKey(KeyCode.W)) {
            Move(Vector3.forward);

            return;
        }

        if(Input.GetKey(KeyCode.A)) {
            Move(Vector3.left);

            return;
        }

        if(Input.GetKey(KeyCode.S)) {
            Move(Vector3.back);

            return;
        }

        if(Input.GetKey(KeyCode.D)) {
            Move(Vector3.right);

            return;
        }
    }

    public void Move(Vector3 dir) {
        transform.position += dir * MovementSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0), Quaternion.LookRotation(dir), Time.deltaTime * 10);
    }

    public float MovementSpeed {
        get; set;
    }

}
