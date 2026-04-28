using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    private bool _isPaused = false;

    private void Start()
    {
        SetPauseState(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _isPaused = !_isPaused;
            SetPauseState(_isPaused);
        }
    }

    private void SetPauseState(bool isPaused)
    {
        if (_panel != null)
            _panel.SetActive(isPaused);

        Time.timeScale = isPaused ? 0f : 1f;
    }
}