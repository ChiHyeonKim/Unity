using UnityEngine;
using System.Collections;
// 배경 스크롤 처리를 한다.
public class BG : MonoBehaviour {
	public float scrollSpeed = 0.2f;

	MeshRenderer mr;
	// Use this for initialization
	void Start () {
		mr = gameObject.GetComponent<MeshRenderer> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		mr.material.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
	
	}
}
