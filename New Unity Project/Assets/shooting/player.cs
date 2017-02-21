using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	public float speed = 5.0f;
    public Joystick joystick;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		// 사용자의 입력을 받아서 움직이도록 한다.
		// 1. 사용자의 입력
		float x = Input.GetAxis ("Horizontal");
        //float x = joystick.gethori
		float y = Input.GetAxis ("Vertical");
		// 2. 움직일 방향찾기
		// 3. 이동시키키
		Vector3 dir = Vector3.right * x + Vector3.forward * y;
		transform.Translate (dir * speed * Time.deltaTime);
	}
}
