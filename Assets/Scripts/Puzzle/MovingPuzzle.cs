using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MovingPuzzle : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool move;
    Vector2 mousePos;
    float startPosX;
    float startPosY;
    public Image form;
    bool finish;

    public void OnPointerDown(PointerEventData eventData)
    {
        move = true;
        mousePos = Input.mousePosition;

        startPosX = mousePos.x - this.GetComponent<RectTransform>().anchoredPosition.x;
        startPosY = mousePos.y - this.GetComponent<RectTransform>().anchoredPosition.y;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        move = false;

        if (Mathf.Abs(this.GetComponent<RectTransform>().anchoredPosition.x - form.GetComponent<RectTransform>().anchoredPosition.x) <= 5f &&
            Mathf.Abs(this.GetComponent<RectTransform>().anchoredPosition.y - form.GetComponent<RectTransform>().anchoredPosition.y) <= 5f && finish != true)
        {
            this.GetComponent<RectTransform>().position = new Vector2(form.GetComponent<RectTransform>().position.x, form.GetComponent<RectTransform>().position.y);
            finish = true;
            PuzzleComplete.AddElement();
        }
    }

    void Update()
    {
        if (move == true && finish == false)
        {
            mousePos = Input.mousePosition;
            this.GetComponent<RectTransform>().localPosition = new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);
        }
    }
}
