using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SampleNameSpace;

public class Testscript : MonoBehaviour
{
    private SimpleScript script;

    private void Start()
    {
        script = GetComponent<SimpleScript>();
    }
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 20, 300, 200), "Hawakan mo ako george!!"))
        {
            string newUserName = script.userName;
            Debug.Log(newUserName); 
        }
    }
}
