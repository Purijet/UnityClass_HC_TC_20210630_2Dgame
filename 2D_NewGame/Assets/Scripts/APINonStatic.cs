using UnityEngine;

public class APINonStatic : MonoBehaviour
{
    // �ϥΫD�R�A�ݩ� 1. ���w�q���D�R�A�ݩʪ����O���
    // �ϥΫD�R�A�ݩ� 3. ��쥲����J�n������T������ �� ���ର�ŭ�
    public Transform traA;
    public Camera cam;
    public Transform traB;
    public Light lightA;

    public Camera camA;
    public SpriteRenderer srA;
    public Transform traC;
    public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        #region �{�ѫD�R�A�ݩ�
        // 1. ���o�D�R�A�ݩ�

        // print("���o�y�СG" + Transform.position); // ���~�G�ݭn������Ѧ�

        // �ϥΫD�R�A�ݩ� 2.
        // �� �y�k�G���.�D�R�A�ݩ�
        print("���o�ߤ���y�СG" + traA.position);
        print("���o��v�����I���C��G" + cam.backgroundColor);

        // 2. �]�w�D�R�A�ݩ�
        // �� �y�k�G���.�D�R�A�ݩ� ���w ��;
        cam.backgroundColor = new Color(0.8f, 0.5f, 0.6f);

        // 3. �I�s�D�R�A��k
        // �� �y�k�G���.�D�R�A��k(�����޼�);
        traB.Translate(1, 0, 0);
        lightA.Reset();
        #endregion

        #region �m�߫D�R�A�ݩ�
        // 1. ���o�D�R�A�ݩ�
        print("��v���`�סG" + camA.depth);
        print("�Ϥ� 1 ���C��G" + srA.color);

        // 2. �]�w�D�R�A�ݩ�
        camA.backgroundColor = Random.ColorHSV();
        srA.flipY = true;
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        // 3. �I�s�D�R�A��k
        traC.Rotate(0, 0, 1);
        rig.AddForce(new Vector2(0, 10));
    }
}
