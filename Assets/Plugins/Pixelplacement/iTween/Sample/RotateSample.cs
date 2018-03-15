using UnityEngine;
using System.Collections;

public class RotateSample : MonoBehaviour
{	
	public void rotateBy(GameObject g){
		iTween.RotateBy(g, new Vector3(0, 0.3f,0), 3.5f);
	}
}

