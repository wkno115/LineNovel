
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Person", menuName = "CreatePerson")]
public class Person : ScriptableObject
{
    public enum KindOfPerson
    {
        player,
        friend,
        noFriend
    }
    //　プロフィールアイコン
    [SerializeField]
    private Sprite profile_icon;
    //　ホーム画面用のアイコン
    [SerializeField]
    private KindOfPerson kindOfPerson;
    [SerializeField]
    private Sprite home_icon;
    //　人の名前
    [SerializeField]
    private string personName;
    //　一言コメント
    [SerializeField]
    private string coment;

    public Sprite Profile_icon
    {
        get
        {
            return profile_icon;
        }
    }

    public Sprite Home_icon
    {
        get
        {
            return home_icon;
        }
    }

    public string PersonName
    {
        get
        {
            return personName;
        }
    }

    public string Coment
    {
        get
        {
            return coment;
        }
    }

    public KindOfPerson GetKindOfPerson()
    {
        return kindOfPerson;
    }
}
