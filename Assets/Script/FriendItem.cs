using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//友だち一覧で表示される友達の項目
public class FriendItem : MonoBehaviour
{
    /// <summary>
    /// 該当のパーソン
    /// </summary>
    [SerializeField]
    public Person _person;
    /// <summary>
    /// フレンドネームテキスト
    /// </summary>
    [SerializeField]
    TextMeshProUGUI _friendNameText;
    /// <summary>
    /// プロフィール画像
    /// </summary>
    [SerializeField]
    Image _profileImage;
    /// <summary>
    /// 一言テキスト
    /// </summary>
    [SerializeField]
    TextMeshProUGUI _commentText;

    void Start()
    {
        _friendNameText.GetComponent<TextMeshProUGUI>().text = _person.PersonName;
        _profileImage.GetComponent<Image>().sprite = _person.Profile_icon;
        if (_person.Comment.Length > 12)
        {
            int count = 0;
            foreach (char ch in _person.Comment)
            {
                _commentText.text += ch;
                count++;
                if (count > 11)
                {
                    _commentText.text += "…";
                    break;   
                }
            }
        }
        else
        {
            _commentText.text = _person.Comment;
        }     
    }
}
