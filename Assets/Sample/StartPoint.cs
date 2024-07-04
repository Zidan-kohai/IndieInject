using UnityEngine;
using UnityEngine.SceneManagement;

namespace Samples
{
    public class StartPoint : MonoBehaviour
    {
        private void Start()
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}