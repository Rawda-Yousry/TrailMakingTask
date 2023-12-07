using UnityEngine;

public class audio : MonoBehaviour
{
    private static audio instance;

    private void Awake()
    {

            DontDestroyOnLoad(gameObject);
            
    }

}
