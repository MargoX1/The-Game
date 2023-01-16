using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeClick : MonoBehaviour
{
    public GameObject TreeBinding_carve;
    public GameObject TreeBinding_draw;
    public GameObject TreeFrost_carve;
    public GameObject TreeFrost_draw;
    public GameObject TreeHel_carve;
    public GameObject TreeHel_draw;
    public GameObject TreeHelName_carve;
    public GameObject TreeHelName_draw;

    public bool _TreeBinding_carve;
    public bool _TreeBinding_draw;
    public bool _TreeFrost_carve;
    public bool _TreeFrost_draw;
    public bool _TreeHel_carve;
    public bool _TreeHel_draw;
    public bool _TreeHelName_carve;
    public bool _TreeHelName_draw;

    void Update()
    {
        if (TreeShow.treeShow == true && KnifeClick.knifeClick == true && BindingClick.bindingClick == true)
        {
            TreeBinding_carve.SetActive(true);
            TreeShow.treeShow = false;
            KnifeClick.knifeClick = false;
            BindingClick.bindingClick = false;
            _TreeBinding_carve = true;
        }
        if (TreeShow.treeShow == true && BrushClick.brushClick == true && BindingClick.bindingClick == true)
        {
            TreeBinding_draw.SetActive(true);
            TreeShow.treeShow = false;
            BrushClick.brushClick = false;
            BindingClick.bindingClick = false;
            _TreeBinding_draw = true;
        }
        if (TreeShow.treeShow == true && KnifeClick.knifeClick == true && FrostClick.frostClick == true)
        {
            TreeFrost_carve.SetActive(true);
            TreeShow.treeShow = false;
            KnifeClick.knifeClick = false;
            FrostClick.frostClick = false;
            _TreeFrost_carve = true;
        }
        if (TreeShow.treeShow == true && BrushClick.brushClick == true && FrostClick.frostClick == true)
        {
            TreeFrost_draw.SetActive(true);
            TreeShow.treeShow = false;
            BrushClick.brushClick = false;
            FrostClick.frostClick = false;
            _TreeFrost_draw = true;
        }

        if (TreeShow.treeShow == true && KnifeClick.knifeClick == true && HelClick.helClick == true)
        {
            TreeHel_carve.SetActive(true);
            TreeShow.treeShow = false;
            KnifeClick.knifeClick = false;
            HelClick.helClick = false;
            _TreeHel_carve = true;
        }
        if (TreeShow.treeShow == true && BrushClick.brushClick == true && HelClick.helClick == true)
        {
            TreeHel_draw.SetActive(true);
            TreeShow.treeShow = false;
            BrushClick.brushClick = false;
            HelClick.helClick = false;
            _TreeHel_draw = true;
        }
        if (TreeShow.treeShow == true && KnifeClick.knifeClick == true && HelClickName.helClickName == true)
        {
            TreeHelName_carve.SetActive(true);
            TreeShow.treeShow = false;
            KnifeClick.knifeClick = false;
            HelClickName.helClickName = false;
            _TreeHelName_carve = true;
        }
        if (TreeShow.treeShow == true && BrushClick.brushClick == true && HelClickName.helClickName == true)
        {
            TreeHelName_draw.SetActive(true);
            TreeShow.treeShow = false;
            BrushClick.brushClick = false;
            HelClickName.helClickName = false;
            _TreeHelName_draw = true;
        }
    }

}
