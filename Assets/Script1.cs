using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour {

    int count;

    public Script1()
    {
        /*empty constructor*/
    }
    public Script1(int count)
    {
        this.count = count;
    }

    public int getCount()
    {
        return count;
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
