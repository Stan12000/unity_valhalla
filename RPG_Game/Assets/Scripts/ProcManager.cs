using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcManager : MonoBehaviour {


	public enum ProcID
	{
		None=0,
		Login,
		CreateChar,
		Main,
		
		TOTAL,
	}
	
	private ProcID curProcID = ProcID.None;
	[SerializeField]
	ProcBase[] procs = new ProcBase[(int)ProcID.TOTAL-1];
	
	public ProcBase GetProc(ProcID proc)
	{
		return procs[(int)proc];
	}
	
	public void SwitchProc(ProcID proc)
	{
		if (curProcID != ProcID.None) {
			ProcBase preProc = GetProc (curProcID);
			preProc.OnLeave ();
		}
		
		ProcBase curProc = GetProc (proc);
		curProc.OnEnter ();
		curProcID = proc;
	}
}

