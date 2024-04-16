using UnityEngine;


public class GameEvents : MonoBehaviour
{

    public struct OnLevelCompleted : IEvent { }
    public struct OnLevelFailed : IEvent { }
    public struct OnLevelGiveUp : IEvent { }
    public struct OnLevelEnded : IEvent { }
    public struct OnLevelLoaded : IEvent{ }

    public struct OnCoinChanged : IEvent {

        public int coin;

        public OnCoinChanged(int coin)
        {
            this.coin = coin;
        }
    }
}
