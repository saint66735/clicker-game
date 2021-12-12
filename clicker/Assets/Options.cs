using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Options : MonoBehaviour
{
    // Start is called before the first frame update
    Resolution[] resolutions;
    public TMP_Dropdown res;
    void Awake()
    {
        resolutions = Screen.resolutions;
        res.ClearOptions();
        List<string> ops = new List<string>();
        int curResIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string text = resolutions[i].width + "x" + resolutions[i].height;
            ops.Add(text);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                curResIndex = i;
            }
        }
        res.AddOptions(ops);
        res.value = curResIndex;
        res.RefreshShownValue();
    }
    public void SetFullscreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }
    public void SelectResolution(int index)
    {
        Resolution res = resolutions[index];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }
}
