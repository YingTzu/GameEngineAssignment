using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class destroyonCollision : MonoBehaviour {
	public Image remind;
	public Image CloseButton;

	private GameObject popOut;

	// Use this for initialization
	void Start () {
		popOut = GameObject.Find ("PopOut");
		remind.enabled = false;
		remind.CrossFadeAlpha(0, 0, false);
		CloseButton.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			remind.enabled = true;
			remind.CrossFadeAlpha(1, 0.5f, false);
			CloseButton.enabled = true;
			this.gameObject.GetComponent<wavePoint>().moveSpeed = 0;
		}
	}

	public void closeButton()
	{
		remind.enabled = false;
		CloseButton.enabled = false;
		Destroy (this.gameObject);
	}
}
