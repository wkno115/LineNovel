using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FriendDetailPanel : MonoBehaviour
{

    /// <summary>
    /// ホーム画像
    /// </summary>
    public Image _homeImage;
    /// <summary>
    /// プロフィール画像
    /// </summary>
    public Image _profileIcon;
    /// <summary>
    /// 名前
    /// </summary>
    public TextMeshProUGUI _personName;
    /// <summary>
    /// 一言コメント
    /// </summary>
    public TextMeshProUGUI _comment;

    public void SetInformation(Person p)
    {
        _homeImage.sprite = p.Home_icon;
        _profileIcon.sprite = p.Profile_icon;
        _personName.text = p.PersonName;
        _comment.text = p.Coment;
    }
}