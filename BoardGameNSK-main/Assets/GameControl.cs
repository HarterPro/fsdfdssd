using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, Player1Icon, Player2Icon, Player3Icon, Player4Icon;

    private static GameObject player1, player2, player3, player4;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int player3StartWaypoint = 0;
    public static int player4StartWaypoint = 0;

    public static bool gameOver = false;

    // Use this for initialization
    void Start () {

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        Player1Icon = GameObject.Find("Player1Icon");
        Player2Icon = GameObject.Find("Player2Icon");
        Player3Icon = GameObject.Find("Player3Icon");
        Player4Icon = GameObject.Find("Player4Icon");

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
        player4 = GameObject.Find("Player4");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        player3.GetComponent<FollowThePath>().moveAllowed = false;
        player4.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        Player1Icon.gameObject.SetActive(true);
        Player2Icon.gameObject.SetActive(false);
        Player3Icon.gameObject.SetActive(false);
        Player4Icon.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex >
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            Player1Icon.gameObject.SetActive(false);
            Player2Icon.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            Player2Icon.gameObject.SetActive(false);
            Player3Icon.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }
        if (player3.GetComponent<FollowThePath>().waypointIndex >
            player3StartWaypoint + diceSideThrown)
        {
            player3.GetComponent<FollowThePath>().moveAllowed = false;
            Player3Icon.gameObject.SetActive(false);
            Player4Icon.gameObject.SetActive(true);
            player3StartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex - 1;
        }
        if (player4.GetComponent<FollowThePath>().waypointIndex >
            player4StartWaypoint + diceSideThrown)
        {
            player4.GetComponent<FollowThePath>().moveAllowed = false;
            Player4Icon.gameObject.SetActive(false);
            Player1Icon.gameObject.SetActive(true);
            player4StartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            Player1Icon.gameObject.SetActive(false);
            Player2Icon.gameObject.SetActive(false);
            Player3Icon.gameObject.SetActive(false);
            Player4Icon.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Победил красный игрок";
            gameOver = true;
        }
        
        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            Player1Icon.gameObject.SetActive(false);
            Player2Icon.gameObject.SetActive(false);
            Player3Icon.gameObject.SetActive(false);
            Player4Icon.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Победил синий игрок";
            gameOver = true;
        }
        if (player3.GetComponent<FollowThePath>().waypointIndex ==
            player3.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            Player1Icon.gameObject.SetActive(false);
            Player2Icon.gameObject.SetActive(false);
            Player3Icon.gameObject.SetActive(false);
            Player4Icon.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Победил зелёный игрок";
            gameOver = true;
        }
        if (player4.GetComponent<FollowThePath>().waypointIndex ==
            player4.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            Player1Icon.gameObject.SetActive(false);
            Player2Icon.gameObject.SetActive(false);
            Player3Icon.gameObject.SetActive(false);
            Player4Icon.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Победил жёлтый игрок";
            gameOver = true;
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 3:
                player3.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 4:
                player4.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
}