using UnityEngine;
using System.Generic;
using System.Collections.Generic;

public enum TESTVAL
{
    None = 0,//0
    Start,   //1
    End,     //2
}

static class Constvalue
{

}
public class NewMonoBehaviourScript : MonoBehaviour
{
    //定数化サンプル
    const int TESTVAL = 1000;
    public const string TESTVAL = "test";

    int[] intval;
    Gameobject[] gameobjects;

    List<int> intlists;

    //これは評価下がる
    Gameobject prefabs1;
    Gameobject prefabs2;
    Gameobject prefabs3;
    
    //こちらの方が当たり前〇
    List<Gameobject> prefabs;
    /// <summary>
    /// テスト関数
    /// </summary>
    ///<param name="arg1">テスト引用１</param>
    ///<param name="arg1">テスト引用１</param>
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame
    void testFunction(int arg1, int arg2)
    {

    }

    void Start()
    { 
        intval = new int[10];
        intlists.add(100);
    }

  
}
