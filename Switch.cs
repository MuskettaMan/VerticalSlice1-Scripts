using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private Animator animation;
    [SerializeField] private Animator animationUse;

    [SerializeField] private GameObject overlapPlatform;

    [SerializeField] private fl_TowerRotation towerRotation;

    private bool thingie = false;
    [SerializeField]private bool canTurnTower = false;

    private float frameCounter = 0;

    private void Start() {
        animation = GetComponent<Animator>();
        overlapPlatform.SetActive(false);
    }

    private void Update() {
        
        if(canTurnTower) {
            towerRotation.RotateTower(0);
            animationUse.SetTrigger("Rise");
            frameCounter++;
            if(frameCounter > 200) {
                canTurnTower = false;
                overlapPlatform.SetActive(true);
            }
        }


    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            if(gameObject.tag == "Switch 1") {
                animation.SetTrigger("Press");
                animationUse.SetTrigger("Rise");
            }

            if(gameObject.tag == "Switch 2") {
                animation.SetTrigger("Press");
                thingie = true;
                canTurnTower = true;
                if(towerRotation.gameObject.transform.eulerAngles.y == 0) {
                    animationUse.SetTrigger("Rise");
                }
            }
        }
    }



}

