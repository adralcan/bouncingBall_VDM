using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GameObject muroIzquierdo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        muroIzquierdo.transform.localScale = new Vector3(4, 4, 4);
        muroIzquierdo.transform.position = new Vector2(transform.position.x - (Screen.width/2), 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
