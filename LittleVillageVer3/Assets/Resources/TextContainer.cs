using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("TextCollection")]
public class TextContainer
{
    [XmlArray("Text")]
    [XmlArrayItem("textDisp")]
    public List<Text> texts = new List<Text>();
}
