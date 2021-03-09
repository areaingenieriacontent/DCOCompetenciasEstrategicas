﻿using SCORM1.Models.MainGame;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoScore.Models.Game
{
    public class SubCategoria
    {
        [Key]
        public int SubC_ID { get; set; }
        public string SubC_Description { get; set; }


        [ForeignKey("Company")]
        public int Company_Id { get; set; }
        public virtual Company Company { get; set; }


        [ForeignKey("Categoria")]
        public int Cate_Id { get; set; }
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<MG_MultipleChoice> MG_MultipleChoice { get; set; }
    }
}