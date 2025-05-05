using UnityEngine;

public class SpatulaBooster : MonoBehaviour, IBoostable
{
    [Header("References")]
    [SerializeField] private Animator _spatulaAnimator;

    [Header("Settings")]
    [SerializeField] private float _jumpForce;

    private bool _isActivated;

    public void Boost(PlayerController playerController)
    {

        if (_isActivated) return;

        PlayBoostAnimator();

        var playerRigitBody = playerController.GetPlayerRigitBody;

        playerRigitBody.linearVelocity = new Vector3(playerRigitBody.linearVelocity.x, 0f, playerRigitBody.linearVelocity.z);
        playerRigitBody.AddForce(transform.forward * _jumpForce, ForceMode.Impulse);

        _isActivated = true;

        Invoke(nameof(ResetActivation), 0.2f);
    }

    private void PlayBoostAnimator()
    {
        _spatulaAnimator.SetTrigger(Consts.OtherAnimations.IS_SPATULA_JUMPIMG);
    }

    private void ResetActivation()
    {
        _isActivated = false;
    }
}
