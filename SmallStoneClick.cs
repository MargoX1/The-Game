using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallStoneClick : MonoBehaviour
{

    public GameObject SmallStoneBinding_carve;
    public GameObject SmallStoneBinding_draw;
    public GameObject SmallStoneFrost_carve;
    public GameObject SmallStoneFrost_draw;
    public GameObject SmallStoneHel_carve;
    public GameObject SmallStoneHel_draw;
    public GameObject SmallStoneHelName_carve;
    public GameObject SmallStoneHelName_draw;

    public bool _SmallStoneBinding_carve;
    public bool _SmallStoneBinding_draw;
    public bool _SmallStoneFrost_carve;
    public bool _SmallStoneFrost_draw;
    public bool _SmallStoneHel_carve;
    public bool _SmallStoneHel_draw;
    public bool _SmallStoneHelName_carve;
    public bool _SmallStoneHelName_draw;

    public void Update()
    {
        if(SmallStoneShow.smallStoneShow == true && KnifeClick.knifeClick == true && BindingClick.bindingClick == true)
        {
            SmallStoneBinding_carve.SetActive(true);
            SmallStoneShow.smallStoneShow = false;
            KnifeClick.knifeClick = false;
            BindingClick.bindingClick = false;
            _SmallStoneBinding_carve = true;
        }
        if (SmallStoneShow.smallStoneShow == true && BrushClick.brushClick == true && BindingClick.bindingClick == true)
        {
            SmallStoneBinding_draw.SetActive(true);
            SmallStoneShow.smallStoneShow = false;
            BrushClick.brushClick = false;
            BindingClick.bindingClick = false;
            _SmallStoneBinding_draw = true;
        }
        if (SmallStoneShow.smallStoneShow == true && KnifeClick.knifeClick == true && FrostClick.frostClick == true)
        {
            SmallStoneFrost_carve.SetActive(true);
            SmallStoneShow.smallStoneShow = false;
            KnifeClick.knifeClick = false;
            FrostClick.frostClick = false;
            _SmallStoneFrost_carve = true;
        }
        if (SmallStoneShow.smallStoneShow == true && BrushClick.brushClick == true && FrostClick.frostClick == true)
        {
            SmallStoneFrost_draw.SetActive(true);
            SmallStoneShow.smallStoneShow = false;
            BrushClick.brushClick = false;
            FrostClick.frostClick = false;
            _SmallStoneFrost_draw = true;
        }

        if (SmallStoneShow.smallStoneShow == true && KnifeClick.knifeClick == true && HelClick.helClick == true)
        {
            SmallStoneHel_carve.SetActive(true);
            SmallStoneShow.smallStoneShow = false;
            KnifeClick.knifeClick = false;
            HelClick.helClick = false;
            _SmallStoneHel_carve = true;
        }
        if (SmallStoneShow.smallStoneShow == true && BrushClick.brushClick == true && HelClick.helClick == true)
        {
            SmallStoneHel_draw.SetActive(true);
            SmallStoneShow.smallStoneShow = false;
            BrushClick.brushClick = false;
            HelClick.helClick = false;
            _SmallStoneHel_draw = true;
        }
        if (SmallStoneShow.smallStoneShow == true && KnifeClick.knifeClick == true && HelClickName.helClickName == true)
        {
            SmallStoneHelName_carve.SetActive(true);
            SmallStoneShow.smallStoneShow = false;
            KnifeClick.knifeClick = false;
            HelClickName.helClickName = false;
            _SmallStoneHelName_carve = true;
        }
        if (SmallStoneShow.smallStoneShow == true && BrushClick.brushClick == true && HelClickName.helClickName == true)
        {
            SmallStoneHelName_draw.SetActive(true);
            SmallStoneShow.smallStoneShow = false;
            BrushClick.brushClick = false;
            HelClickName.helClickName = false;
            _SmallStoneHelName_draw = true;
        }
    }
}
