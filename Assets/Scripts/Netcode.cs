using UnityEngine;
using Unity.Netcode;
public class Netcode : NetworkBehaviour
{
    NetworkVariable<int> playerscore = new NetworkVariable<int>();
}
