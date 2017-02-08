using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour {
	
	public UIManager uiManager;
	public ProcManager procManager;
	
	public ProcManager.ProcID startProc;

	private static GameMain _instance = null;
	public static GameMain Instance
	{
		get
		{
			return _instance;
		}
	}

	void Awake()
	{
		_instance = this;
	}
	
	// Use this for initialization
	void Start () {
		procManager.SwitchProc (startProc);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy()
	{
		_instance = null;
	}
}
