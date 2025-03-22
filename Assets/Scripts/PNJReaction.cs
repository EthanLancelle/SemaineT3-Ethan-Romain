using UnityEngine;

public class PnjReaction : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("IsTriggered", true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("IsTriggered", false);
        }
    }

}