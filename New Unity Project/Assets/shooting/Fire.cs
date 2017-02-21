using UnityEngine;
using System.Collections;
// 사용자가 mouse left 버튼 클릭 or lefr ctrl 키 누르면 Bullet을 발사한다.
public class Fire : MonoBehaviour {
	// 총알 공장의 주소
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// 사용자가 mouse left 버튼 클릭 or lefr ctrl 키 누르면
		// 1. 만약 mouse left 클릭 되었다면
		if (Input.GetButtonDown ("Fire1")) {
			// 2. bullet 의 위치를 만든다.
			GameObject bullet = Instantiate (bulletPrefab);
			// 3. bullet 의 위치를 지정한다.
			bullet.transform.position = transform.position;
		}
	}
}
