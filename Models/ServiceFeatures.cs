using System.ComponentModel.DataAnnotations;

namespace TemplateTask.Models
{
    public class ServiceFeatures
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Header { get; set; }
        public string Body { get; set; }
        public string Icon { get; set; }
    }
}
