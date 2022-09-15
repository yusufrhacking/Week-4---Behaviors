using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate.GetComponent<MoveObject>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other){
        // objectToActivate.GetComponent<MoveObject>().enabled = true;
    }

    private void OnTriggerStay(Collider other){
        objectToActivate.GetComponent<MoveObject>().enabled = true;
    }

    private void OnTriggerExit(Collider other){
        objectToActivate.GetComponent<MoveObject>().enabled=false;
        objectToActivate.GetComponent<MoveObject>().FlipMoveDirection();
        // objectToActivate.GetComponent<MoveObject>().enabled = true;
        // float distanceTraveled = objectToActivate.GetComponent<MoveObject>().GetDistanceTraveled();

        // if (distanceTraveled > objectToActivate.GetComponent<MoveObject>().totalMoveDistance)
        // {
        //     objectToActivate.GetComponent<MoveObject>().FlipMoveDirection();
        // }

        // objectToActivate.GetComponent<MoveObject>().gameObject.transform.Translate(
        //     objectToActivate.GetComponent<MoveObject>().moveDirection 
        //     * 
        //     objectToActivate.GetComponent<MoveObject>().moveSpeed);
    }
}
