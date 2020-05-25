using System;
using System.ComponentModel.DataAnnotations;

namespace MvcToDo.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool Complete { get; set; }
    }
}