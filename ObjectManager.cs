using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour {

	void Start () {
		//Game Objectを破棄しないようにする
		DontDestroyOnLoad (gameObject);
	}

	public void DestroyObject(){
		Destroy (gameObject);
	}

}
