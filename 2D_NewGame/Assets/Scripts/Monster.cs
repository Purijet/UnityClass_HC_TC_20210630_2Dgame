using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public int atk = 100;
    [Header("血量"), Range(0, 5000)]
    public int hp = 350;
    [Header("掉落道具"), Tooltip("用來儲存道具是否掉落的資訊，掉落true，沒掉落false")]
    public bool isProps = false;
    [Header("道具掉落機率"), Range(0, 1)]
    public float chsProps = 1;
    [Header("道具掉落音效"), Tooltip("用來儲存道具掉落音效的資訊")]
    public string sound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

}
