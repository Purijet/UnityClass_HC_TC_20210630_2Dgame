using UnityEngine;

public class Player : MonoBehaviour
{
    #region ���
    [Header("���ʳt��"), Range(0, 1000)]
    public float speed = 300.0f;
    [Header("���D����"), Range(0, 3000)]
    public int jump = 1200;
    [Header("��q"), Range(0, 200)]
    public float hp = 100;
    [Header("�O�_�b�a�O�W"), Tooltip("�Ψ��x�s����O�_�b�a�O�W����T�A�b�a�O�W true�A���b�a�O�W false")]
    public bool isGround;
    [Header("���O"), Range(0.01f, 1)]
    public float gravity = 0.1f;

    // �p�H��줣���
    // �}���ݩʭ��O�����Ҧ� Debug �i�H�ݨ�p�H���
    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
    /// <summary>
    /// ���a������J��
    /// </summary>
    private float hValue;
    #endregion

    #region �ƥ�
    private void Start()
    {
        // GetComponent<����>() �x����k�A�i�H���w��������
        // �@�ΡG���o������ 2D ���餸��
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // �@������� 60 ��
    private void Update()
    {
        GetPlayerInputHorizontal();
        TurnDirection();
        Jump();
        Attack();
    }

    // �T�w��s�ƥ�
    // �@��T�w���� 50 ���A�x���ĳ���ϥΨ쪫�z API �n�b���ƥ󤺰���
    private void FixedUpdate()
    {
        Move(hValue);
    }

    [Header("�ˬd�a�O�ϰ�G�첾�P�b�|")]
    public Vector3 groundOffset;
    [Range(0, 2)]
    public float groundRadius = 0.1f;

    // ø�s�ϥܡG���U�}�o�̥ΡA�ȷ|��ܦb�s�边 Unity ��
    private void OnDrawGizmos()
    {
        // ���M�w�C��Aø�s�ϥ�
        Gizmos.color = new Color(1, 0, 0, 0.3f);        // �b�z������
        // ø�s�y��(�����I,�b�|)
        Gizmos.DrawSphere(transform.position + groundOffset, groundRadius);
    }
    #endregion

    #region ��k

    /// <summary>
    /// ���o���a��J�����b�V�ȡGA�BD�B���B�k
    /// </summary>
    private void GetPlayerInputHorizontal()
    {
        // ������ = ��J.���o�b�V(�b�V�W��)
        // �@�ΡG���o���a���U�������䪺�ȡA���k�� 1 �B������ -1 �B�S���� 0
        hValue = Input.GetAxis("Horizontal");
        // print("���a�����ȡG" + hValue);
    }

    /// <summary>
    /// ����
    /// </summary>
    private void Move(float horizontal)
    {
        /** �Ĥ@�ز��ʤ覡�G�ۭq���O...
        // �ϰ��ܼơG�b��k�������A���ϰ�ʡA�ȭ��󦹤�k���s��
        // transform ������ Transform �ܧΤ���
        // posMove = �����e�y�� + ���a��J��������
        // Time.fixedDeltaTime �� 1/50 ��
        Vector2 posMove = transform.position + new Vector3(horizontal, -gravity, 0) * speed * Time.fixedDeltaTime;
        // ����.���ʮy��(�n�e�����y��)
        rig.MovePosition(posMove);
        */

        /** �ĤG�ز��ʤ覡�G�ϥαM�פ������O - ���w�C */
        rig.velocity = new Vector2(horizontal * speed * Time.fixedDeltaTime, rig.velocity.y);

        ani.SetBool("�����}��", horizontal != 0);
    }

    /// <summary>
    /// �����V�G�B�z���⭱�V���D�A���k���� 0 �A�������� 180
    /// </summary>
    private void TurnDirection()
    {
        // print("���a���U�k�G" + Input.GetKeyDown(KeyCode.D));
        // �p�G ���a�� D �N�N���׳]�� 0, 0, 0
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = Vector3.zero;
        }
        // �p�G ���a�� A �N�N���׳]�� 0, 180, 0
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }

    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {
        // Vector2 �Ѽƥi�H�ϥ� Vector3 �N�J�A�{���|�۰ʧ� Z �b����
        // << �첾�B��l
        // ���w�ϼh�y�k�G1 << �ϼh�s��
        Collider2D hit = Physics2D.OverlapCircle(transform.position + groundOffset, groundRadius, 1 << 6);

        // �p�G �I�쪫��s�b �N�N��b�a���W �_�h �N�N���A�a���W
        // �P�_���p�G�u�� �@�ӵ����Ÿ��F �i�H�ٲ��j�A��
        if(hit)
        {
            isGround = true;
            // print("�I�쪺����G" + hit.name);
        }
        else
        {
            isGround = false;
        }

        ani.SetBool("���DĲ�o", !isGround);

        // �p�G ���a ���U �ť��� ����N���W���D
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rig.AddForce(new Vector2(0, jump));
        }
    }

    [Header("�����N�o"), Range(0, 5)]
    public float cd = 2;

    /// <summary>
    /// �����p�ɾ�
    /// </summary>
    private float timer;
    /// <summary>
    /// �O�_����
    /// </summary>
    private bool isAttack;

    private void Attack()
    {
        // �p�G ���U ���� �Ұ�Ĳ�o�Ѽ�
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isAttack = true;
            ani.SetTrigger("����Ĳ�o");
        }
        // �p�G ���U����������N�}�l�֥[�ɶ�
        if (isAttack)
        {
            timer += Time.deltaTime;
            print("������֥[�ɶ��G" + timer);
        }
    }
    #endregion
}
