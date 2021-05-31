using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This layer will be used to house the models for our application.  These models will be classes used in almost all layers of our application

namespace ElevenNote.Models
{
    // This first model will handle the task of collecting property data for a list of notes.  When a user enters information, we will want them to enter specific data.  When we show information, we will want to show specific data in specific views

    public class NoteListItem
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
