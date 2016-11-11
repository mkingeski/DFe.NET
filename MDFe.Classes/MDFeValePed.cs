﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ManifestoDocumentoFiscalEletronico.Classes
{
    [Serializable]
    public class MDFeValePed
    {
        [XmlElement(ElementName = "disp")]
        public List<MDFeDisp> Disp { get; set; }
    }
}