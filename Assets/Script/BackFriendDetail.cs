using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BackFriendDetail : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BackMove()
    {
        this.gameObject.transform.DOLocalMove(
            new Vector3(0,-1600f,this.gameObject.transform.position.z),
            0.7f
            );
    }
}
