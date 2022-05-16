using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDissapear : MonoBehaviour
{
    public bool callGlobalBoolDissolve;
    public float timer =1;
    private GameObject thisGameObject;
    // Start is called before the first frame update
    void Start()
    {
        thisGameObject = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (QuestCollisionTrigger.globalBoolDissolve)
        Object.Destroy(gameObject, timer);

    }
}
