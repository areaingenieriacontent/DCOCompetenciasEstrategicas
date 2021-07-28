using SCORM1.Models.MainGame;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoScore.Models.Game
{
    public class MG_Context
    {
        [Key]
        public int Contex_Id { get; set; }

        [Display(Name = "Descripción Contexto")]
        public string Contex_Desc { get; set; }

        [Display(Name = "Nombre Competencia")]
        public string Contex_Compet { get; set; }

        [Display(Name = "Fuente o Autor")]
        public string Contex_Autor { get; set; }

        public virtual ICollection<MG_MultipleChoice> MG_MultipleChoice { get; set; }
    }
}