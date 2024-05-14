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
        // Join ��ư ��Ȱ��ȭ
        joinButton.interactable = false;

        // �Է� �ʵ忡 �̺�Ʈ �߰�
        playerNameInput.onValueChanged.AddListener(OnInputValueChanged);
    }

    private void OnInputValueChanged(string newValue)
    {
        // �Է°� ���̰� 2���� 10 �������� Ȯ���Ͽ� Join ��ư Ȱ��ȭ ���� ����
        joinButton.interactable = newValue.Length >= 2 && newValue.Length <= 10;
    }

    public void JoinGame()
    {
        // ������ �̵�
        SceneManager.LoadScene("MainScene");
    }
}
