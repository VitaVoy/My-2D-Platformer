using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    [SerializeField]
    private Button _back;

    private void Awake()
    {
        _back.onClick.AddListener(ReturnBack);
    }

    private void ReturnBack()
    {
        SceneManager.LoadScene("Level 1");
    }
}
