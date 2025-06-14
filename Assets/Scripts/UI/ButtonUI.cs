using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private AnimationClip anim;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    public void OnClick()
    {
        if (animator != null)
        {
            animator.Play(anim.name);
        }
        else
        {
            Debug.LogWarning("Animator component not found on " + gameObject.name);
        }
    }
}
