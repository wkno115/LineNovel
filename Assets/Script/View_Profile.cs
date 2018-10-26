using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class View_Profile : MonoBehaviour {
    public GameObject detailPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void View_profile()
    {
        detailPanel.transform.DOLocalMove(
                new Vector3(detailPanel.transform.localPosition.x, 0, detailPanel.transform.localPosition.z),
                0.7f
            );
    }
}
