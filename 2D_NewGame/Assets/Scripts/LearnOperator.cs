using UnityEngine;

// �{�ѹB��l
// 1. �ƾǹB��l
public class LearnOperator : MonoBehaviour
{
    public int a = 10;
    public int b = 3;
    public int c = 7;
    public int hp = 100;

    public float scoreA = 99;
    public float scoreB = 1;
    public int key = 0;
    public int chest = 0;
    public int diamond = 0;

    // Start is called before the first frame update
    private void Start()
    {
        #region �ƾǹB��l
        print(a + b);       // 13
        print(a - b);       // 7
        print(a * b);       // 30
        print(a / b);       // 3
        print(a % b);       // 1

        // ���W ++
        c = c + 1;          // = ���w�Ÿ��G�k����B��A���w������
        c++;                // ²�g
        print("c �B��᪺���G�G" + c);
        // ���� --

        // ���w�B��
        hp = hp - 13;       // 87
        hp -= 13;           // 74
        hp += 20;           // 94
        #endregion

        #region ����B��l
        // > < >= <= == !=
        // �ϥΤ���B��l�����G ���O���L��
        // ������G���T��true �_�h��false
        print("99 �j�� 1�G" + (scoreA > scoreB));              // true
        print("99 �p�� 1�G" + (scoreA < scoreB));              // false
        print("99 �j�󵥩� 1�G" + (scoreA >= scoreB));         // true
        print("99 �p�󵥩� 1�G" + (scoreA <= scoreB));         // false
        print("99 ���� 1�G" + (scoreA == scoreB));             // false
        print("99 ������ 1�G" + (scoreA != scoreB));           // true
        #endregion

        #region �޿�B��l
        // ����ⵧ���L�Ȫ����
        // �åB &&
        // �u�n���@�ӥ��L�Ȭ� false ���G�N�� false
        print(true && true);        // true
        print(true && false);       // false
        print(false && true);       // false
        print(false && false);      // false

        // �Ϊ� ||
        // �u�n���@�ӥ��L�Ȭ� true ���G�N�� true
        print(true || true);        // true
        print(true || false);       // true
        print(false || true);       // true
        print(false || false);      // false

        // �L������G��q �j�� 0 �åB �_�� �n���� 1
        print("�O�_�L���G" + (hp > 0 && key == 1));
        // �L������G�_�c �j�󵥩� 5 �ε� �p�� �j�󵥩� 2
        print("�O�_�L���G" + (chest >= 5 || diamond >= 2));

        // �ۤ� !
        print(!true);
        print(!false);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
