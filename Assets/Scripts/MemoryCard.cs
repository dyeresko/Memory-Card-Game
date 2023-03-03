using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject cardBack;

    [SerializeField] SceneController controller;

    private int _id;
    public int Id
    {
        get
        {
            return _id;
        }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Unreavel()
    {
        cardBack.SetActive(true);
    }

    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
