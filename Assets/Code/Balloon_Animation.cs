using System.Collections;
using UnityEngine;

public class Balloon_Animation : MonoBehaviour {

	SpriteRenderer Balloon;
	public Sprite Frame_0;
	public Sprite Frame_1;
	public Sprite Frame_2;
	public Sprite Frame_3;
	public Sprite Frame_4;
	public Sprite Frame_5;
	public Sprite Frame_6;
	public Sprite Frame_7;
	float Delay = .15f;

	void Start () {
		Balloon = this.gameObject.GetComponent<SpriteRenderer>();
		StartCoroutine(Animate());
	}

	IEnumerator Animate () {
		while (1 > 0) {
			Balloon.sprite = Frame_0;
			yield return new WaitForSecondsRealtime(Delay);
			Balloon.sprite = Frame_1;
			yield return new WaitForSecondsRealtime(Delay);
			Balloon.sprite = Frame_2;
			yield return new WaitForSecondsRealtime(Delay);
			Balloon.sprite = Frame_3;
			yield return new WaitForSecondsRealtime(Delay);
			Balloon.sprite = Frame_4;
			yield return new WaitForSecondsRealtime(Delay);
			Balloon.sprite = Frame_5;
			yield return new WaitForSecondsRealtime(Delay);
			Balloon.sprite = Frame_6;
			yield return new WaitForSecondsRealtime(Delay);
			Balloon.sprite = Frame_7;
			yield return new WaitForSecondsRealtime(Delay);
		}
	}
}