using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public Script1 script1;
	// Use this for initialization
	void Start () {
        script1 = new Script1(123);
        Debug.Log("count = " + script1.getCount());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
