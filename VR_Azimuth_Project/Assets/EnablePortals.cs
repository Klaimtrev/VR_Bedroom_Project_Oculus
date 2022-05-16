using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePortals : MonoBehaviour
{
    public GameObject[] Portals;
    // Start is called before the first frame update
    IEnumerator ExampleCoroutine()
    {
        

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);


    }
    IEnumerator FirstCoroutine()
    {


        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(8);


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {

        bool callGlobalBoolDissolveDone = ChangeMatValueCutHeight.DissolveDone;
        if (callGlobalBoolDissolveDone)
        {
            FirstCoroutine();
            foreach (GameObject Portal in Portals) {
                Portal.SetActive(true);
                ExampleCoroutine();
            }
        }
    }

}
