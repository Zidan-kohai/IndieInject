using IndieInject;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Inject] private InputSystem input;

    private void Start()
    {
        if (input == null)
        {
            Debug.Log("Input isn`t inject");
        }
    }


    private void Update()
    {
        if (input.LoadScene)
        {
            SceneManager.LoadScene(2);
        }
    }
}
