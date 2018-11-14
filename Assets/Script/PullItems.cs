using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class PullItems : MonoBehaviour
{
    public float doneTime;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Close()
    {
        List<GameObject> gameObjects = new List<GameObject>();
        foreach (Transform transform in gameObject.transform)
        {
            // Transformからゲームオブジェクト取得・削除
            gameObjects.Add(transform.gameObject);
        }

        for (int i = 0; i < gameObjects.Count; i++)
        {
            gameObjects[i].transform.DOLocalMove(
                new Vector3(gameObjects[i].transform.localPosition.x, gameObjects[0].transform.parent.localPosition.y + 160, gameObjects[i].transform.localPosition.z),
                doneTime
                );
        }
    }

    public void Open()
    {
        List<GameObject> gameObjects = new List<GameObject>();
        foreach (Transform transform in gameObject.transform)
        {
            // Transformからゲームオブジェクト取得・削除
            gameObjects.Add(transform.gameObject);
        }

        for (int i = 0; i < gameObjects.Count; i++)
        {
            gameObjects[i].transform.DOLocalMove(
                new Vector3(gameObjects[i].transform.localPosition.x, 
                gameObjects[0].transform.parent.localPosition.y - (gameObjects[0].GetComponent<RectTransform>().sizeDelta.y * i) - 50,
                gameObjects[i].transform.localPosition.z),
                doneTime
                );
            Debug.Log(gameObjects[i].transform.localPosition.y);
        }
    }
}
