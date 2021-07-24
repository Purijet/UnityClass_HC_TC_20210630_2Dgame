using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("�����O"), Range(0, 500)]
    public int atk = 100;
    [Header("��q"), Range(0, 5000)]
    public int hp = 350;
    [Header("�����D��"), Tooltip("�Ψ��x�s�D��O�_��������T�A����true�A�S����false")]
    public bool isProps = false;
    [Header("�D�㱼�����v"), Range(0, 1)]
    public float chsProps = 1;
    [Header("�D�㱼������"), Tooltip("�Ψ��x�s�D�㱼�����Ī���T")]
    public string sound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

}
