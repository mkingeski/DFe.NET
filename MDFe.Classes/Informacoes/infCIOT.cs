﻿using System.Collections.Generic;

namespace MDFe.Classes.Informacoes
{
    public class infCIOT
    {
        public string CIOT { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }

        public MDFeValePed valePed { get; set; }

        public List<infContratante> infContratante { get; set; }
    }
}