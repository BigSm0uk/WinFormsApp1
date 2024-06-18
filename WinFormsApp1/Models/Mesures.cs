using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Mesures
    {
        public Guid Id { get; init; }
        public int Field { get; init; }
        public required string Name { get; init; } = string.Empty;
        public required string Description { get; init; } = string.Empty;
        public required string State { get; init; } = string.Empty;

    }
}
