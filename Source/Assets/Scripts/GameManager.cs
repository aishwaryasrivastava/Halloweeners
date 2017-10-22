using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public GameObject thePlayer;
    private void Awake()
    {
        thePlayer.SetActive(false);
    }
    private void Start()
    {
        BeginGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RestartGame();
        }
    }


    public Maze mazePrefab;

    private Maze mazeInstance;

    private void BeginGame()
    {

        mazeInstance = Instantiate(mazePrefab) as Maze;
        StartCoroutine(mazeInstance.Generate(thePlayer));

    }

    private void RestartGame()
    {
        StopAllCoroutines();
        Destroy(mazeInstance.gameObject);
        BeginGame();
    }

}
	