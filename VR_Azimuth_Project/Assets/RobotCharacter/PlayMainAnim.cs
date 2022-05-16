using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMainAnim : MonoBehaviour
{

    private void Update()
    {

        if (ChangeMatValueCutHeight.DissolveDone)
        {
            GetComponent<Animator>().Play("MainAnim");
        }
    }
}
