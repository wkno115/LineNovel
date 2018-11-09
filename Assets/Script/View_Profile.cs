using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class View_Profile : MonoBehaviour
{
    public GameObject detailPanel;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void View_profile()
    {
        GameObject.Instantiate(detailPanel);
        detailPanel.transform.DOLocalMove(
                new Vector3(detailPanel.transform.position.x, detailPanel.transform.position.y, 0),
                0.7f
            );
    }
}
