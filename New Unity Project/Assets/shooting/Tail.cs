using UnityEngine;
using System.Collections;

public class Tail : MonoBehaviour {
	// 전역변수 선언
	public GameObject player;
	// Player 의 이동 속력
	public float speed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// 하고 싶은 것
		// 1. 나는 Player를 따라 다니고 싶다.
		//  - player 가 어디에 있는지 찾자.
		Vector3 playerPos = player.transform.position;
		// - 나는 어디있는가?
		Vector3 myPos = transform.position;
		//  - player 가 위치한 방향을 찾자.
		// -> targetVector = player - me;
		Vector3 dir = playerPos - myPos;
		// - 크기를 1로 만들어 주야 한다.
		dir.Normalize();
		//  - 찾은  방향으로 이동하자.
		transform.Translate(dir * speed * Time.deltaTime);
		// transform.position = transform.position + dir * 5 * Time.deltaTime;
	}
}
