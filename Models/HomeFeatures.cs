using System.ComponentModel.DataAnnotations;

namespace TemplateTask.Models
{
    public class HomeFeatures
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Header { get; set; }
        public string Body { get; set; }
        public string Icon { get; set; }
    }
}
