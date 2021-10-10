using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Models
{
    public class Job
    {
        [Required]public string JobTitle { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")] public int Salary { get; set; }
        
        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }
        
        
        
        
        
    }
}