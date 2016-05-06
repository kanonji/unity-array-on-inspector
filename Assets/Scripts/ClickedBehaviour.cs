using UnityEngine;

namespace Kanonji
{
	public class ClickedBehaviour : MonoBehaviour
	{
		private string objectName = "Container";

		public void Clicked()
		{
			Object.Destroy(GameObject.Find(objectName));
			var conainer = new GameObject(objectName);

			var obj = new GameObject("ArrayOnMonoBehaviour").AddComponent<ArrayOnMonoBehaviour>();
			obj.transform.SetParent(conainer.transform);

			var objInEdit = new GameObject("ArrayOnMonoBehaviourInEditMode").AddComponent<ArrayOnMonoBehaviourInEditMode>();
			objInEdit.transform.SetParent(conainer.transform);
		}
	}
}
