using UnityEngine;

public class StateController : MonoBehaviour
{
    private PlayerState _currentPlayerState = PlayerState.Idle;

    private void Start()
    {
        _currentPlayerState = PlayerState.Idle;
    }

    public void ChangeState(PlayerState newPlayerState)
    {
        if (_currentPlayerState == newPlayerState) return;

        _currentPlayerState = newPlayerState;
    }

    public PlayerState GetCurrentState => _currentPlayerState;


}
