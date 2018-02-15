using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapmove : MonoBehaviour {

    public float speed;
    public RectTransform tubes1;
    public RectTransform tubes2;

    private RectTransform _transform;
	// Use this for initialization
	void Awake () {
        _transform = transform as RectTransform;
    }
	
	// Update is called once per frame
	void Update () {
        speed = 300f + (Time.time % 5) * 5f;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (_transform.anchoredPosition.x <= -940)
        {
            _transform.anchoredPosition = new Vector2(940f, 0);
            tubes1.anchoredPosition = new Vector2(tubes1.anchoredPosition.x, Random.Range(-139, 198));
            tubes2.anchoredPosition = new Vector2(tubes2.anchoredPosition.x, Random.Range(-139, 198));
        }
    }
}
