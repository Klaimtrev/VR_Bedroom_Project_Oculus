using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMatValueCutHeight : MonoBehaviour
{

    public static bool DissolveDone = false;


    public Material CutOffHeight;
    public string PropertyName;

    public float HeightCut =0;

    public float LowValue;
    public float MaxValue;

    public float BlendsSpeed = 0.005f;

    public bool callGlobalBoolDissolve;

    public GameObject DestroyObject;

    // Start is called before the first frame update
    void Start()
    {
        //DestroyObject = this.GetComponent<GameObject>();
        //callGlobalBoolDissolve = QuestCollisionTrigger.globalBoolDissolve;

    }
    void OnGUI()
    {
        CutOffHeight.SetFloat(PropertyName, MaxValue);
    }

    // Update is called once per frame
    void Update()
    {
        callGlobalBoolDissolve = QuestCollisionTrigger.globalBoolDissolve;

        if (callGlobalBoolDissolve) {
            CutOffHeight.SetFloat(PropertyName, HeightCut);
            HeightCut += BlendsSpeed;
            //Destroy(DestroyObject, 1.0f);
        }
        if (HeightCut < -8f) {
            DissolveDone = true;
            DestroyGameObject();
        }


        /*
        CutOffHeight.SetFloat(PropertyName, HeightCut);

        HeightCut += BlendsSpeed;
        if ((HeightCut > MaxValue) || (HeightCut < LowValue)) {
            BlendsSpeed *= -1;
        }
        */

    }
    void DestroyGameObject()
    {
        Destroy(DestroyObject);
    }
}
