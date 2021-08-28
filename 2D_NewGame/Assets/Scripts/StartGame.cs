using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
