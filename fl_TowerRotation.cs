using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fl_TowerRotation : MonoBehaviour {
    [SerializeField] private float turnSpeed = 5f;

    private void Update() {
        if(!CanTurn) {
            SetTowerToDefault();
        }
    }

    public void RotateTower(float rotateTowards) {
        transform.rotation = Quaternion.Slerp(Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0), Quaternion.Euler(new Vector3(0, rotateTowards, 0)), Time.deltaTime * turnSpeed);
    }

    private void SetTowerToDefault() {
        float rotation = transform.rotation.eulerAngles.y;
        
        //East
        if(rotation > 45 && rotation < 135) {
            RotateTower(90);
        }
        //South
        if(rotation > 135 && rotation < 225) {
            RotateTower(180);
        }
        //West
        if(rotation > 225 && rotation < 315) {
            RotateTower(270);
        }

        //North
        if((rotation > -45 && rotation < 45) || (rotation > 315 && rotation < 405)) {
            RotateTower(0);
        }

        

    }

    private void OnMouseDown() {
        CanTurn = true;
    }

    private void OnMouseUp() {
        CanTurn = false;
    }


    public bool CanTurn {
        get; set;
    }


}
