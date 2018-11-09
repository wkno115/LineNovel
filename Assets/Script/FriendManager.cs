using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendManager : MonoBehaviour
{
    /// <summary>
    /// 人々のデータベース
    /// </summary>
    public PersonDataBase personDataBase;
    /// <summary>
    /// フレンドアイテムオブジェクト
    /// </summary>
    public GameObject friendItem;
    /// <summary>
    /// フレンドアイテムのリスト
    /// </summary>
    public List<GameObject> friendItemList;
    /// <summary>
    /// フレンドアイテムを扱うオブジェクト
    /// </summary>
    public GameObject friendItemHandler;
    /// <summary>
    /// フレンド詳細画面
    /// </summary>
    public GameObject friendDetailPanel;

    private List<Person> people;
    // Use this for initialization
    void Start()
    {
        friendItemList = new List<GameObject>();
        people = personDataBase.GetPersonLists();
        CreateFriendItem();
    }

    /// <summary>
    /// フレンドアイテムを人数分生成
    /// </summary>
    public void CreateFriendItem()
    {
        int count = 0;
        foreach (Person p in people)
        {
            GameObject go = Instantiate(friendItem) as GameObject;
            go.transform.parent = friendItemHandler.transform;
            go.GetComponent<FriendItem>().person = p;
            go.transform.localPosition -= new Vector3(0, count * go.GetComponent<RectTransform>().sizeDelta.y+2, 0);
            count++;
        }
    }
}
