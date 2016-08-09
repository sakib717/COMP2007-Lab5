using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//Added data to the Song's model created 
namespace COMP2007_S2016_Lesson12C.Models
{
    public class Song
    {
        [Key]
        public virtual int SongId { get; set; }

        public virtual string SongName { get; set; }

        public virtual string Duration { get; set; }
    }
}