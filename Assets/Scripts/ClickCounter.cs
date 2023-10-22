using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    private int clickCount = 0;

    public void IncrementClickCount()
    {
        clickCount++;
    }

    public int GetClickCount()
    {
        return clickCount;
    }
}