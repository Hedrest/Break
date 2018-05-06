using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public static GameController Instance;
    public MouseCursor cursorController;

	// Use this for initialization
	void Awake () {
        Instance = this;
		
	}
	
}
