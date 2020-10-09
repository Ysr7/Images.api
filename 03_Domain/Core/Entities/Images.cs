using System;

namespace Core.Entities
{
    public class Images
    {
        public int Id { get; set; }
        public string Descripion { get; set; }
        public double Size { get; set; }
        public string Path { get; set; }
        public DateTime Data { get; set; }
    }
}