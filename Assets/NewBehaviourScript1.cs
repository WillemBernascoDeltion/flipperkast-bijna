using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

    public Vector3 cordinate;
    public bool xmag;
    public bool ymag;
    public bool zmag;
   
    //use this for initalization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += cordinate;
    }
}
