using DG.Tweening;
using UnityEngine;

public class View_Profile : MonoBehaviour
{
    /// <summary>
    /// 詳細パネル
    /// </summary>
    [SerializeField]
    FriendDetailPanel _detailPanel;
    /// <summary>
    /// 詳細ビュー
    /// </summary>
    [SerializeField]
    GameObject _detailView;
    /// <summary>
    /// フレンドアイテム
    /// </summary>
    [SerializeField]
    FriendItem _friendItem;

    public void View_profile()
    {
        _detailPanel.SetInformation(_friendItem.person);
        _detailView.transform.DOLocalMove(
                new Vector3(0, -_detailView.GetComponent<RectTransform>().sizeDelta.y, 0),
                0.7f
            );
    }
}
