using UnityEngine;
using System.Collections;

public class Arm : MonoBehaviour {
	public Vector2 SPEED = new Vector2(0.05f, 0.05f);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 Position = transform.position;
		// 左キーを押し続けていたら
		if(Input.GetKey("b")){
			// 代入したPositionに対して加算減算を行う
			Position.x -= SPEED.x;
		} else if(Input.GetKey("v")){ // 右キーを押し続けていたら
			// 代入したPositionに対して加算減算を行う
			Position.x += SPEED.x;
		}
		// 現在の位置に加算減算を行ったPositionを代入する
		transform.position = Position;
	}
}
