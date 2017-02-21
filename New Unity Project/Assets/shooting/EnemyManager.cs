using UnityEngine;
using System.Collections;

//일정 시간이 되면 Enemy를 생성 한다.
public class EnemyManager : MonoBehaviour {

	public GameObject enemy;
	public float createTime = 1;
	float currentTime = 0; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime; //0.1 second

		//enemy create
		if (currentTime > createTime) {
			currentTime = 0;

			GameObject enemyObj = Instantiate (enemy);
			float x = Random.Range (-80, 80);
			enemyObj.transform.position = new Vector3 (x, 0.705f, 33.2f);
		}
	}
}
