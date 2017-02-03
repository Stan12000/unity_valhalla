using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcManager : MonoBehaviour {
	
	public enum ProcID
	{
		None = 0,
		Login,
		CreateChar,
		ForeWord,
		Main,
	}

	public ProcManager.ProcID curProcID;
    ProcBase [] procs

	public void SwitchProc(ProcID procID)
	{
		//destory curProcID
		ProcBase v = new ProcBase ();
		v.onLeave();
		//change curProcID -> procID
		curProcID = procID;


	}


}
