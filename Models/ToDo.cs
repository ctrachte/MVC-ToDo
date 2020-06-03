using System;
using System.ComponentModel.DataAnnotations;

namespace MvcToDo.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CompletedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        public bool Complete { get; set; }
    }
}