
using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using WebP;

public class WebPTest : MonoBehaviour
{
	//------------------------------------------------------------------------------------------------------------	
    public Material m_Material = null;

    //------------------------------------------------------------------------------------------------------------	
	private void Start()
	{
        if (m_Material != null)
        {
            Error lError;

            var lData = File.ReadAllBytes(@"Assets/Example/Data/image01.webp");

			Texture2D lTexture2D = new Texture2D(1024, 1024, TextureFormat.RGBA32, false, false);
            lTexture2D.LoadWebP(lData, out lError);

			if (lError == Error.Success)
			{
            	m_Material.mainTexture = lTexture2D;
			}
			else
			{
				Debug.LogError("Webp Load Error : " + lError.ToString());
			}
        }
	}
}
	