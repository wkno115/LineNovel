using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PersonDataBase", menuName = "CreatePersonDataBase")]
public class PersonDataBase : ScriptableObject
{

    [SerializeField]
    private List<Person> personList = new List<Person>();

    //　アイテムリストを返す
    public List<Person> GetPersonLists()
    {
        return personList;
    }
}