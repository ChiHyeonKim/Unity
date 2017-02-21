using UnityEngine;
using System.Collections;

//Enemy 가 앞으로 내려오도록 하고싶다.
// 충돌을하면 폭발 효과를 주고싶다.

// 2. 폭발 만들기
// 3. 위치 지정

public class Enemy : MonoBehaviour {
	public GameObject player;
	public float speed = 5.0f;
	Vector3 dir;
	// 1. 폭발prefab 공장 주소
	public GameObject explosionPrefab;

	// Use this for initialization
	void Start () {
		Vector3 playerPos = player.transform.position;
		Vector3 myPos = transform.position;
		dir = playerPos - myPos;
		dir.Normalize();
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (dir * speed * Time.deltaTime);
	}
	// 충돌하면 제거한다.
	void OnCollisionEnter(Collision other)
	{
		// 2. 폭발 만들기
		GameObject explosion = Instantiate (explosionPrefab);
		// 3. 위치 지정
		explosion.transform.position = transform.position;
		Destroy (other.gameObject);
		Destroy (gameObject);
	}


}

