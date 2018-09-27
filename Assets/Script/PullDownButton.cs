using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PullDownButton : MonoBehaviour {
    private bool opened;
    public GameObject items;
    public Image arrow;
	// Use this for initialization
	void Start () {
        opened = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Do()
    {
        if (opened)
        {
            Close();
        }
        else
        {
            Open();
        }
    }

    void Close()
    {
        items.GetComponent<PullItems>().Close();
        opened = false;
        arrow.transform.Rotate(new Vector3(0,0,180));
    }

    void Open()
    {
        items.GetComponent<PullItems>().Open();
        opened = true;
        arrow.transform.Rotate(new Vector3(0, 0, 180));
    }
}
