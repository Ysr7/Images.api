using System;

namespace Core.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Descripion { get; set; }
        public int Length { get; set; }
        public string Picture { get; set; }
        public DateTime Data { get; set; }
    }
}