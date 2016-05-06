using UnityEngine;
using tm.Extensions;

namespace Kanonji
{
	[DisallowMultipleComponent]
	public class ArrayOnMonoBehaviour : MonoBehaviour
	{
		[SerializeField] private Vector3[] noInitializing;
		[SerializeField] private Vector3[] initializedZero = new Vector3[0];
		[SerializeField] private Vector3[] initialized = new Vector3[]
		{
			Vector3.back,
			Vector3.up,
			Vector3.forward,
		};

		void Start()
		{
			Debug.Log("ArrayOnMonoBehaviour".Bold().Large().Blue());
			Debug.Log("\n");
			Debug.Log("noInitializing".Bold().Large());
			Debug.Log(noInitializing);
			Debug.Log(noInitializing.Length);

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
