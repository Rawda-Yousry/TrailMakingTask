using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer currentLine;
    private List<Vector3> linePositions = new List<Vector3>();
    private Vector2 endPosition;

    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     StartNewLine();
        // }
    }

    public void StartNewLine()
    {
        if (endPosition == new Vector2 (0f, 0f)){
            endPosition =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else{
            GameObject lineObject = new GameObject("Line");
            currentLine = lineObject.AddComponent<LineRenderer>();
            currentLine.positionCount = 2;
            currentLine.useWorldSpace = true;

            currentLine.startWidth = 0.1f;  
            currentLine.endWidth = 0.1f;

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            linePositions.Clear();
            linePositions.Add(new Vector3(endPosition.x, endPosition.y, 0f));
            linePositions.Add(new Vector3(mousePos.x, mousePos.y, 0f));

            currentLine.SetPositions(linePositions.ToArray());
            endPosition = new Vector3(mousePos.x, mousePos.y, 0f);
        }
    }

}
