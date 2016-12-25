using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public bool test3;
    public int test;
    public float willem;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        PlusEen();
        Praten();
    }
    public void PlusEen()
    {
        if (test3)
        {
            test = test + 1;
        }
        test = test + 1;
    }
    public void Praten() { 
    willem = willem + 0.5f;
 }
} 
