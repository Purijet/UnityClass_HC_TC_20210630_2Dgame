using UnityEngine;

/// <summary>
/// �{�� API �H�βĤ@�إΪk�G�R�A Static
/// </summary>
public class APIstatic : MonoBehaviour
{
    // API ���A������j��
    // 1. �R  �A�G������r static
    // 2. �D�R�A�G�L����r static

    // �ݩʡGProperties �i�H�z�Ѭ����P�����
    // ��k�GMethods

    // Start is called before the first frame update
    void Start()
    {
        // �R�A�ݩ�
        // 1. ���o
        // �� �y�k�G���O.�R�A�ݩ�
        print("�H���ȡG" + Random.value);
        print("�L���j�G" + Mathf.Infinity);

        // 2. �]�w
        // �� �y�k�G���O.�R�A�ݩ� ���w ��;
        Cursor.visible = false;
        // Random.value = 7.7f; - �߿W�ݩʤ���]�w Read Only
        Screen.fullScreen = true;

        // �R�A��k
        // 3. �I�s
        // �� �y�k�G���O.�R�A��k(�����޼�)
        float r = Random.Range(7.5f, 9.8f);
        print("�H���d�� 7.5 ~ 9.8�G" + r);
    }

    public float hp = 70;

    // Update is called once per frame
    void Update()
    {
        hp = Mathf.Clamp(hp, 0, 100);           // �ƾ�.����(��,�̤p��,�̤j��) - �N��J���ȧ��b�̤p�̤j�d��
        print("��q�G" + hp);
    }
}
