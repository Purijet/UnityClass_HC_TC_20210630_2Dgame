
using UnityEngine;          // �ޥ� Unity ���� ���Ѫ� API (Unity Engine �R�W�Ŷ�)

// ���O
// �y�k : ���O����r �}���W��
public class Car : MonoBehaviour
{
    #region ����
    // ������ : �K�[�����B½Ķ�B��������...�|�Q�{������
    // Purijet 2021.07.17 (��) �}�o�T���}��

    /* �h�����
     * 
     * 
     */
    #endregion

    #region ���P�`�Υ|�j����
    // ��� : �x�s²�檺���
    // �y�k : 
    // ������� ���W�� ���w�Ÿ� �w�]�� ����
    // ���w�Ÿ� =
    // �׹��� :
    // 1. �p�H private �w�] - �����
    // 2. ���} public       - ���

    // Unity �`�Υ|�j����
    // ���   int
    // �B�I�� float
    // �r��   string
    // ���L�� bool

    // �w�q���
    public float weight = 3.5f;
    public int cc = 2000;
    public string brand = "���h";
    public bool windowSky = true;

    // �i�H�ϥΤ���A����ĳ - �s�X���D�P�ഫ�į���D
    // �W�߶}�o�A�ζ��\�i
    public int ���L�ƶq = 4;
    #endregion

    #region ����ݩ�
    // ����ݩ� : ���U���K�[�B�~�\��
    // �y�k : [�ݩʦW��(�ݩʭ�)]
    // ���D : [Header(�r��)]
    [Header("���L�ƶq")]
    public int wheelCount;
    // ���� : [Tooltip(�r��)]
    [Tooltip("�o����쪺�ت��O�]�w�T��������...")]
    public float height = 1.5f;
    // �d�� : [Range( �̤p�ƭ�)]
    #endregion

    #region ��L����
    // �C�� Color
    public Color color1;                                            //�����w���¦�z��
    public Color red = Color.red;                                   //�ϥιw�]�C��
    public Color yellow = Color.yellow;
    public Color colorCustom1 = new Color(0.5f, 0.5f, 0);           //�ۭq�C��(R�BG�BB)
    public Color colorCustom2 = new Color(0.5f, 0, 0.5f, 0.5f);     //�ۭq�C��(R�BG�BB�BA)

    // �y�� 2 - 4 �� Vector2 - 4
    // �O�s�ƭȸ�T�B�B�I��
    public Vector2 v2;
    public Vector2 v2Zero = Vector2.zero;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Custom = new Vector2(-99.5f, 100.5f);

    public Vector3 v3;
    public Vector4 v4;

    // ��������
    public KeyCode kc;
    public KeyCode forward = KeyCode.D;
    public KeyCode attack = KeyCode.Mouse0;     // ���� 0 �B �k��1 �B �u�� 2

    // �C������P����
    public GameObject goCamera;         // �C������]�t�����W���P�M�פ����w�m��
    // ����ȭ���s���ݩʭ��O�������󪺪���
    public Transform traCar;
    public SpriteRenderer sprpicture;
    #endregion

    #region �ƥ�
    // �}�l�ƥ�G����C���ɰ���@��
    private void Start()
    {
        // ��X�����������
        print("���o�A�U�w~ :P");

        // �m�ߨ��o��� Get
        print(brand);
        // �m�߳]�w��� Set
        windowSky = true;
        cc = 5000;
        weight = 9.9f;

        // �I�s��k�y�k�G��k�W��();
        Drive50();
        Drive100();
        Drive(150);     // �I�s�ɤp�A�������Ƭ��޼�
        Drive(200);
        // Drive(80, "�H��");         // �ɳt 80�A���� �������A�S�� �H�� - ���~
        Drive(80, effect: "�H��");    // �ϥΦh�ӹw�]�ȰѼƮɥi�H�ϥ� �ѼƦW��: ��

        float kg = KG();
        print("�ର���窺��T�G" + kg);
    }

    // ��s�ƥ�G�j���@�� 60 ���B60FPS�B�B�z���󲾰ʩεۺ�ť���a��J
    private void Update()
    {
        // print("�ڦb update �� @3@");
    }
    #endregion

    #region ��k(�\��B�禡)Method
    // ��k�G��@����������欰�A�Ҧp�G�T�����e�}�B�}�ҨT�������T�ü��񭵼�..
    // ���y�k�G�׹��� ��    �� �W�� ���w �w�]�ȡF
    // ��k�y�k�G�׹��� �Ǧ^���� �W�� (...) {�{���϶�}�F
    // �����Gvoid - �L�Ǧ^
    // �w�q��k�A���|���檺�����I�s�A�I�s���覡�G�b�ƥ󤺩I�s����k
    // ���@�ʡA�X�R��

    private void Drive50()
    {
        print("�}�����A�ɳt�G50");
    }
    private void Drive100()
    {
        print("�}�����A�ɳt�G100");
    }
    // �Ѽƻy�k�G���� �ѼƦW�� - �g�b�p�A�����A�Ȧb����k���i�ϥ�
    // �Ѽ�1�B�Ѽ�2�B�Ѽ�3......�Ѽ�N
    // �Ѽƹw�]�ȡG���� �ѼƦW�� ���w �� (��񦡰Ѽ�)
    // �w�]�ȥu���b�̥k��

    /// <summary>
    /// �o�O�}������k�A�i�H�Ψӱ���}���ɪ��t�סB���ĻP�S��
    /// </summary>
    /// <para name="speed">���l�����ʳt��</param>
    /// <para name="sound">�}���ɪ�����</param>
    /// <para name="effect">�}���ɭn���񪺯S��</param>
    private void Drive(int speed, string sound = "������", string effect = "�ǹ�")
    {
        print("�}�����A�ɳt�G" + speed);
        print("�}�����ġG" + sound);
        print("�}���S�ġG" + effect);
    }

    /// <summary>
    /// �����ഫ������
    /// </summary>
    /// <returns>�ର���窺���q��T</returns>
    private float KG()
    {
        return weight * 1000;
    }
    #endregion
}
