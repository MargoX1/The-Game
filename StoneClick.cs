using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneClick : MonoBehaviour
{

    public GameObject StoneBinding_carve;
    public GameObject StoneBinding_draw;
    public GameObject StoneFrost_carve;
    public GameObject StoneFrost_draw;
    public GameObject StoneHel_carve;
    public GameObject StoneHel_draw;
    public GameObject StoneHelName_carve;
    public GameObject StoneHelName_draw;

    public static bool _StoneBinding_carve;
    public static bool _StoneBinding_draw;
    public static bool _StoneFrost_carve;
    public static bool _StoneFrost_draw;
    public static bool _StoneHel_carve;
    public static bool _StoneHel_draw;
    public static bool _StoneHelName_carve;
    public static bool _StoneHelName_draw;

    void Update()
    {
        if (StoneShow.stoneShow == true && KnifeClick.knifeClick == true && BindingClick.bindingClick == true)
        {
            StoneBinding_carve.SetActive(true);
            StoneShow.stoneShow = false;
            KnifeClick.knifeClick = false;
            BindingClick.bindingClick = false;
            _StoneBinding_carve = true;
        }
        if (StoneShow.stoneShow == true && BrushClick.brushClick == true && BindingClick.bindingClick == true)
        {
            StoneBinding_draw.SetActive(true);
            StoneShow.stoneShow = false;
            BrushClick.brushClick = false;
            BindingClick.bindingClick = false;
            _StoneBinding_draw = true;
        }
        if (StoneShow.stoneShow == true && KnifeClick.knifeClick == true && FrostClick.frostClick == true)
        {
            StoneFrost_carve.SetActive(true);
            StoneShow.stoneShow = false;
            KnifeClick.knifeClick = false;
            FrostClick.frostClick = false;
            _StoneFrost_carve = true;
        }
        if (StoneShow.stoneShow == true && BrushClick.brushClick == true && FrostClick.frostClick == true)
        {
            StoneFrost_draw.SetActive(true);
            StoneShow.stoneShow = false;
            BrushClick.brushClick = false;
            FrostClick.frostClick = false;
            _StoneFrost_draw = true;
        }

        if (StoneShow.stoneShow == true && KnifeClick.knifeClick == true && HelClick.helClick == true)
        {
            StoneHel_carve.SetActive(true);
            StoneShow.stoneShow = false;
            KnifeClick.knifeClick = false;
            HelClick.helClick = false;
            _StoneHel_carve = true;
        }
        if (StoneShow.stoneShow == true && BrushClick.brushClick == true && HelClick.helClick == true)
        {
            StoneHel_draw.SetActive(true);
            StoneShow.stoneShow = false;
            BrushClick.brushClick = false;
            HelClick.helClick = false;
            _StoneHel_draw = true;
        }
        if (StoneShow.stoneShow == true && KnifeClick.knifeClick == true && HelClickName.helClickName == true)
        {
            StoneHelName_carve.SetActive(true);
            StoneShow.stoneShow = false;
            KnifeClick.knifeClick = false;
            HelClickName.helClickName = false;
            _StoneHelName_carve = true;
        }
        if (StoneShow.stoneShow == true && BrushClick.brushClick == true && HelClickName.helClickName == true)
        {
            StoneHelName_draw.SetActive(true);
            StoneShow.stoneShow = false;
            BrushClick.brushClick = false;
            HelClickName.helClickName = false;
            _StoneHelName_draw = true;
        }
    }

}
