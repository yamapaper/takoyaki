using UnityEngine;

public class ItemPos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ゲームオブジェクトのワールド座標を取得
        Vector3 worldPos = Pos.transform.position;

        // スクリーン座標に変換
        Vector3 screenPos = Camera.main.WorldToScreenPoint(worldPos);
    }



    
}
