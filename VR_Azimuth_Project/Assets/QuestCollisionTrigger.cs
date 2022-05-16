using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCollisionTrigger : MonoBehaviour
{
    public void update() {
        Debug.Log("The global dissolve is set to " + globalBoolDissolve);
    }
    public static bool globalBoolDissolve = false;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Object: " + collision.gameObject.name);
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if ((collision.gameObject.name == "r_controller_ply")|| (collision.gameObject.name == "l_controller_ply"))
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("RightHand");
        }
        else { Debug.Log("NOT RightHand/LeftHand"); }
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "MyGameObjectTag")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if ((other.gameObject.name == "r_controller_ply") || (other.gameObject.name == "l_controller_ply"))
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            globalBoolDissolve = true;
            Debug.Log("RightHand");
        }
    }
}
