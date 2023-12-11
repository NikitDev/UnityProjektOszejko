using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveUpDown : MonoBehaviour
{
    public List<Transform> places;
    private int CurrentPlace = 0;
    public float MoveTime = 0.1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MovePlayer(-1);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            MovePlayer(1);
        }
    }

    void MovePlayer(int direction)
    {
        CurrentPlace += direction;
        CurrentPlace = Mathf.Clamp(CurrentPlace, 0, places.Count - 1);

        Vector2 startPosition = transform.position;
        Vector2 destination = places[CurrentPlace].position;

        StartCoroutine(Position(startPosition, destination));
    }

    IEnumerator Position(Vector2 start, Vector2 destination)
    {
        float time = 0f;

        while (time < MoveTime)
        {
            transform.position = Vector2.Lerp(start, destination, time / MoveTime);
        
            time += Time.deltaTime;
        
            yield return null;
        }

        transform.position = destination;
    }
}
