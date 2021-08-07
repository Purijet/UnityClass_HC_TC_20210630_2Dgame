using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    public float a = 0, b = 10;
    public float result;

    public float c = 0, d = 100;

    public Vector2 v2A = Vector2.zero;
    public Vector2 v2B = Vector2.one * 100;

    void Start()
    {
        // �{�Ѵ��� lerp�G���o���I������
        // ���G = �ƾ�.����(A�I, B�I, �ʤ��� 0 - 1)
        result = Mathf.Lerp(a, b, 0.5f);
    }

    void Update()
    {
        c = Mathf.Lerp(c, d, 0.5f * Time.deltaTime);
        v2A = Vector2.Lerp(v2A, v2B, 0.8f * Time.deltaTime);
    }
}