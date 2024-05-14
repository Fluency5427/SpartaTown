using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject nameTagPrefab;
    private GameObject nameTagInstance;

    private void Update()
    {
        // 캐릭터가 움직일 때 이름표도 같이 이동
        if (nameTagInstance != null)
        {
            nameTagInstance.transform.position = transform.position + Vector3.up * 2f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            // 맵에 들어왔을 때 이름표를 생성
            nameTagInstance = Instantiate(nameTagPrefab, transform.position + Vector3.up * 2f, Quaternion.identity);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            // 맵을 떠날 때 이름표 제거
            Destroy(nameTagInstance);
        }
    }
}