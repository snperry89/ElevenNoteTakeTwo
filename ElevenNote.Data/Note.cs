using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Added this whole class
namespace ElevenNote.Data
{
    // Entities used in web APIs are similar to POCOs in previous projects
    public class Note  // Make it public
    {
        // The 'Key' annotation specifies the property that uniquely identifies an entity -- the primary 'key' of the corresponding database
        [Key] 
        public int NoteId { get; set; }
        // The 'Required' annotation ensures the user does not enter a null value

        [Required]
        // A Guid (Globablly Unique Identifier) is a type that allows us to create unique, near impossible to replicate IDs for our users or items for our users
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
