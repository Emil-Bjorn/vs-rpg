using UnityEngine;
using UnityEngine.UIElements;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    private Label healthLabel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        healthLabel = root.Q<Label>("HealthLabel");
        healthLabel.text = $"Health: {playerHealth.CurrentHealth}";
    }

    // Update is called once per frame
    void Update()
    {
        healthLabel.text = $"Health: {playerHealth.CurrentHealth}";
    }
}
