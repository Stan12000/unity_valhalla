using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour {
	
	public UIManager uiManager;
	public ProcManager procManager;
	
	public ProcManager.ProcID startProc;
	
	void Awake()
	{
	}
	
	// Use this for initialization
	void Start () {
		//procManager.SwitchProc (startProc);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
