using UnityEngine;
using System.Collections;

public class NewBehaviourScript3 : MonoBehaviour {
    public Vector3 dir;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(dir);
	}
}
