using System.Collections.Generic;
using UnityEngine;

//プレイヤーを管理するクラス
public class PlayerManager : MonoBehaviour
{
    [SerializeField] private List<ItemData> _itemDataList = new List<ItemData>();   //プレイヤーの所持アイテム

    //アイテムを取得
    public void CountItem(string itemId, int count)
    {
        for (int i = 0; i < _itemDataList.Count; i++)
        {
            //IDが一致していたらカウント
            if (_itemDataList[i].id == itemId)
            {
                _itemDataList[i].CountUp(count);
                break;
            }
        }

        //IDが一致しなければアイテムを追加
        ItemData itemData = new ItemData(itemId, count);
        _itemDataList.Add(itemData);
    }

    //アイテムを使用
    public void UseItem(string itemId,int count) 
    {
        //List内を検索
        for (int i = 0; i < _itemDataList.Count; i++)
        {
            //IDが一致していたらカウント
            if (_itemDataList[i].id == itemId)
            {
                //アイテムをカウントダウン
                _itemDataList[i].CountDown(count);
                break;
            }
        }
    }
}