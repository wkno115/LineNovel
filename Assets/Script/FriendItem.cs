using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//友だち一覧で表示される友達の項目
public class FriendItem : MonoBehaviour {
    public Person person;
    public GameObject friendName, profileImage;
	// Use this for initialization
	void Start () {
        friendName.GetComponent<TextMeshProUGUI>().text = person.PersonName;
        profileImage.GetComponent<Image>().sprite = person.Profile_icon;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
