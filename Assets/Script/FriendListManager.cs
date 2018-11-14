using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FriendListManager : MonoBehaviour
{
    /// <summary>
    /// 人々のデータベース
    /// </summary>
    [SerializeField]
    PersonDataBase _personDataBase;
    /// <summary>
    /// フレンドアイテムオブジェクト
    /// </summary>
    [SerializeField]
    GameObject _friendItem;
    /// <summary>
    /// フレンドアイテムを扱うオブジェクト
    /// </summary>
    [SerializeField]
    GameObject _friendItemHandler;
    /// <summary>
    /// フレンド詳細画面
    /// </summary>
    [SerializeField]
    FriendDetailPanel _friendDetailPanel;
    /// <summary>
    /// フレンドラベルテキスト
    /// </summary>
    [SerializeField]
    TextMeshProUGUI _friendLabelText;

    /// <summary>
    /// フレンドアイテムのリスト
    /// </summary>
    List<GameObject> _friendItemList;
    /// <summary>
    /// フレンドのリスト
    /// </summary>
    List<Person> _friendList;



    void Awake()
    {
        _friendItemList = new List<GameObject>();
        _friendList = _personDataBase.GetPersonLists();
        _friendLabelText.text = _personDataBase.GetPersonLists().Count.ToString();
        CreateFriendItem();
    }

    /// <summary>
    /// フレンドアイテムを人数分生成
    /// </summary>
    public void CreateFriendItem()
    {        
        int count = 0;
        foreach (Person p in _friendList)
        {
            if (count == 0)
            {
                _friendItem.GetComponent<FriendItem>().person = p;
            }
            else
            {
                GameObject go = Instantiate(_friendItem,_friendItemHandler.transform) as GameObject;
                go.GetComponent<FriendItem>().person = p;
                go.transform.position -= new Vector3(0, count * go.GetComponent<RectTransform>().sizeDelta.y + 2, 0);
            }
            count++;
        }
    }

    /// <summary>
    /// フレンド詳細画面を表示
    /// </summary>
    IEnumerator ViewFriendDetailPanel(Person p)
    {
        _friendDetailPanel.SetInformation(p);
        yield return null;
    }
}
