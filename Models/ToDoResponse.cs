using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6GroupAssignment.Models
{
    public class ToDoResponse
    {
        [Key]
        [Required]
        public int ToDoListId { get; set; }

        [Required(ErrorMessage = "Can't watch a movie without knowing the title...")]
        public string Task { get; set; }
       
        public string DueDate { get; set; }
        
        [Required(ErrorMessage = "Which Quadrant is it in?")]
        public int Quadrant { get; set; }
        
        public string Completed { get; set; }

     
        //Foreign Key Relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
