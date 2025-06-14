using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class TextHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI text;
    private Vector3 originalScale;
    public Color hoverColor = Color.cyan;

    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        originalScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = hoverColor;
        transform.localScale = originalScale * 1.1f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = Color.white;
        transform.localScale = originalScale;
    }
}
