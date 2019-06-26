﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPMS_DOMAIN.ENTITIES
{
   public class IntershipSheet
    {
        public int IdIntershipSheet { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Issue { get; set; }
        public string Fonctionality { get; set; }
        public string Keyword { get; set; }
        public string PersoMail { get; set; }
        public string PeroMail { get; set; }
        public DateTime Date { get; set; }

        public IntershipAgreementShhet IntershipAgreementShhet;
        public Compagny Compagny;
        public Student Student;
        public GraduationProposal GraduationProposal;
        public List<SheetState> SheetStateList;
    }

}
