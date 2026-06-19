using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private UnityEvent onTriggered;
    private void OnTriggerEnter(Collider Other)

    {
        if (Other.CompareTag("Player"))
        {
            onTriggered?.Invoke();
            Destroy(gameObject);
        }
    }

  
   
}
