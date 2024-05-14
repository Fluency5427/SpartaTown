using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public InputField playerNameInput;
    public string playerName;

    public Button joinButton;

    // Start is called before the first frame update
    private void Start()
    {
        // Join 버튼 비활성화
        joinButton.interactable = false;

        // 입력 필드에 이벤트 추가
        playerNameInput.onValueChanged.AddListener(OnInputValueChanged);
    }

    private void OnInputValueChanged(string newValue)
    {
        // 입력값 길이가 2에서 10 사이인지 확인하여 Join 버튼 활성화 여부 결정
        joinButton.interactable = newValue.Length >= 2 && newValue.Length <= 10;
    }

    public void JoinGame()
    {
        // 맵으로 이동
        SceneManager.LoadScene("MainScene");
    }
}
