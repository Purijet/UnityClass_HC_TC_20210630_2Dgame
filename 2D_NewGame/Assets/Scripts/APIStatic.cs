using UnityEngine;

/// <summary>
/// 認識 API 以及第一種用法：靜態 Static
/// </summary>
public class APIstatic : MonoBehaviour
{
    // API 文件，分為兩大類
    // 1. 靜  態：有關鍵字 static
    // 2. 非靜態：無關鍵字 static

    // 屬性：Properties 可以理解為等同於欄位
    // 方法：Methods

    // Start is called before the first frame update
    void Start()
    {
        // 靜態屬性
        // 1. 取得
        // ※ 語法：類別.靜態屬性
        print("隨機值：" + Random.value);
        print("無限大：" + Mathf.Infinity);

        // 2. 設定
        // ※ 語法：類別.靜態屬性 指定 值;
        Cursor.visible = false;
        // Random.value = 7.7f; - 唯獨屬性不能設定 Read Only
        Screen.fullScreen = true;

        // 靜態方法
        // 3. 呼叫
        // ※ 語法：類別.靜態方法(對應引數)
        float r = Random.Range(7.5f, 9.8f);
        print("隨機範圍 7.5 ~ 9.8：" + r);
    }

    public float hp = 70;

    // Update is called once per frame
    void Update()
    {
        hp = Mathf.Clamp(hp, 0, 100);           // 數學.夾住(值,最小值,最大值) - 將輸入的值夾在最小最大範圍內
        print("血量：" + hp);
    }
}
