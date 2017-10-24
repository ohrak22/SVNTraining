using UnityEngine;
using System.Collections;

public class ScriptA : MonoBehaviour
{

	void Start()
	{
		for (int i = 0; i < 3; i++)
		{
			Debug.Log(i);

			int num = i + i;

			Debug.Log(num);
		}
	}

}
