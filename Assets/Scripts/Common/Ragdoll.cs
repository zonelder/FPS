using UnityEngine;


public class Ragdoll : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private Rigidbody[] _rigids;
    private void Awake()
    {
        _rigids = GetComponentsInChildren<Rigidbody>();
        DeactivateRagdoll();
    }

    public void ActivateRagdoll()
    {
        foreach (var rigidBody in _rigids)
        {
            rigidBody.isKinematic = false;
 
        }
        _animator.enabled = false;
    }

    public void DeactivateRagdoll()
    {
        foreach(var rigidBody in _rigids)
        {
            rigidBody.isKinematic = true;
        }
        _animator.enabled = true;
    }
}
