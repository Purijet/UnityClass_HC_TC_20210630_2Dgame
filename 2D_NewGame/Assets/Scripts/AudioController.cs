using UnityEngine;
using UnityEngine.Audio;            // �ޥ� ���� API

public class AudioController : MonoBehaviour
{
    [Header("�V����")]
    public AudioMixer mixer;

    // �Ʊ� silder �� On Value Change �ƥ�G�ư��ܧ�ƭȮɰ���@��
    // (Single) ���� float

    /// <summary>
    /// �]�w BGM ���q
    /// </summary>
    /// <param name="volume"></param>
    public void SetVolumeBGM(float volume)
    {
        mixer.SetFloat("VolumeBGM", volume);
    }

    /// <summary>
    /// �]�w SFX ���q
    /// </summary>
    /// <param name="volume"></param>
    public void SetVolumeSFX(float volume)
    {
        mixer.SetFloat("VolumeSFX", volume);
    }
}
