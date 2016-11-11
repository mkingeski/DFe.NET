﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ManifestoDocumentoFiscalEletronico.Classes.Contratos;

namespace ManifestoDocumentoFiscalEletronico.Classes
{
    [Serializable]
    public class MDFeRodo : IMDFeModal
    {
        [XmlElement(ElementName = "RNTRC")]
        public string RNTRC { get; set; }

        [XmlElement(ElementName = "CIOT")]
        public string CIOT { get; set; }

        [XmlElement(ElementName = "veicTracao")]
        public MDFeVeicTracao VeicTracao { get; set; }

        [XmlElement(ElementName = "veicReboque")]
        public List<MDFeVeicReboque> VeicReboque { get; set; }

        [XmlElement(ElementName = "valePed")]
        public MDFeValePed ValePed { get; set; }

        [XmlElement(ElementName = "codAgPorto")]
        public string CodAgPorto { get; set; }
    }
}