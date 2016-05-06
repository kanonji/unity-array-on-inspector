using System;
using UnityEngine;
using UnityEngine.UI;
using tm.Extensions;

namespace Kanonji
{
	[DisallowMultipleComponent]
	public class ArrayOnBaseMeshEffect : BaseMeshEffect
	{
		[SerializeField] private Vector3[] noInitializing;
		[SerializeField] private Vector3[] initializedZero = new Vector3[0];
		[SerializeField] private Vector3[] initialized = new Vector3[]
		{
			Vector3.back,
			Vector3.up,
			Vector3.forward,
		};

		public override void ModifyMesh(VertexHelper vh)
		{
			if (!IsActive())
				return;

			Debug.Log("ArrayOnBaseMeshEffect".Bold().Large().Blue());
			Debug.Log("\n");
			Debug.Log("noInitializing".Bold().Large());
			Debug.Log(noInitializing);
			try
			{
				Debug.Log(noInitializing.Length);
			}
			catch (Exception e)
			{
				Debug.Log(e.ToString().Red());
			}

			Debug.Log("initializedZero".Bold().Large());
			Debug.Log(initializedZero);
			Debug.Log(initializedZero.Length);

			Debug.Log("initialized".Bold().Large());
			Debug.Log(initialized);
			Debug.Log(initialized.Length);
			Debug.Log("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
		}
	}
}

