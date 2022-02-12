using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPanel : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public static DraggableBlock d;
    List<DraggableBlock> cardsOnTabletop = new List<DraggableBlock>();
    List<string> cardsOnTabletopNames = new List<string>();
    List<Transform> Col1 = new List<Transform>();
    List<Transform> Col2 = new List<Transform>();
    List<Transform> Col3 = new List<Transform>();
    List<Transform> Col4 = new List<Transform>();
    List<Transform> Col5 = new List<Transform>();
    List<Transform> Col6 = new List<Transform>();
    List<Transform> Col7 = new List<Transform>();
    List<Transform> Col8 = new List<Transform>();
    List<List<Transform>> columns = new List<List<Transform>>();


    //public Transform A4, A5, A6, B4, B5, B6, C4, C5, C6, D4, D5, D6, E4, E5, E6, F4, F5, F6, G4, G5, G6, H4, H5, H6;

    void Start()
    {
        GameObject gameControl = GameObject.Find("GameControl");
        GameControl gameControlScript = gameControl.GetComponent<GameControl>();

        Col1.Add(gameControlScript.A1);
        //Col1.Add(gameControlScript.A2);
        //Col1.Add(gameControlScript.A3);

        Col2.Add(gameControlScript.B1);
        //Col2.Add(gameControlScript.B2);
        //Col2.Add(gameControlScript.B3);

        Col3.Add(gameControlScript.C1);
        //Col3.Add(gameControlScript.C2);
        //Col3.Add(gameControlScript.C3);

        Col4.Add(gameControlScript.D1);
        //Col4.Add(gameControlScript.D2);
        //Col4.Add(gameControlScript.D3);

        Col5.Add(gameControlScript.E1);
        //Col5.Add(gameControlScript.E2);
        //Col5.Add(gameControlScript.E3);

        Col6.Add(gameControlScript.F1);
        //Col6.Add(gameControlScript.F2);
        //Col6.Add(gameControlScript.F3);

        Col7.Add(gameControlScript.G1);
        //Col7.Add(gameControlScript.G2);
        //Col7.Add(gameControlScript.G3);

        Col8.Add(gameControlScript.H1);
        //Col8.Add(gameControlScript.H2);
        //Col8.Add(gameControlScript.H3);

        columns.Add(Col1);
        columns.Add(Col2);
        columns.Add(Col3);
        columns.Add(Col4);
        columns.Add(Col5);
        columns.Add(Col6);
        columns.Add(Col7);
        columns.Add(Col8);

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        // if (d != null)
        // {
        //     d.placeholderParent = this.transform;
        // }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        // if (d != null && d.placeholderParent == this.transform)
        // {
        //     d.placeholderParent = d.parentToReturnTo;
        // }
    }

    public void OnDrop(PointerEventData eventData)
    {
        d = eventData.pointerDrag.GetComponent<DraggableBlock>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }

        //   StartCoroutine((RegisterWord()));
    }

    // IEnumerator RegisterWord()
    // {
    //     yield return new WaitForSeconds(0.1f);

    //     GameObject gameControl = GameObject.Find("GameControl");
    //     GameControl gameControlScript = gameControl.GetComponent<GameControl>();
    //     gameControlScript.UpdateStage();
    // }
}
