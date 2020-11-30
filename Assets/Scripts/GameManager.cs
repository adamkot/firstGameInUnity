using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lifes;
    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void DecrementLifes()
    {
        lifes--;
    }

    void Start()
    {
        lifes = 3;
    }

}
