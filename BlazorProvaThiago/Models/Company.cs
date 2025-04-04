using System.Collections.Generic;

namespace BlazorProvaThiago.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;
        public int FoundedYear { get; set; }
        public List<FinancialData> FinancialHistory { get; set; } = new List<FinancialData>();
    }
}
