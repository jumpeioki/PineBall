using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour {

	private int score = 0;
	private GameObject pointText;

	void Start () {
		this.pointText = GameObject.Find("PointText");
	}

	void Update () {
		this.pointText.GetComponent<Text>().text = score.ToString();

	}
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "SmallStarTag") {
			score += 10;
		} else if (other.gameObject.tag == "LargeStarTag") {
			score += 30;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			score += 20;
		} else if (other.gameObject.tag == "LargeCloudTag"){
			score += 40;
		}

	}
}
