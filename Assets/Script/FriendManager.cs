using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendManager : MonoBehaviour {
    public PersonDataBase personDataBase;
    public GameObject FriendItem;
    private List<Person> people;
    // Use this for initialization
    void Start() {
        people=personDataBase.GetPersonLists();
        foreach (Person p in people)
        {
            GameObject.Instantiate(FriendItem);
            FriendItem.GetComponent<FriendItem>().person = p;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
