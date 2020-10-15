using System;

namespace Core.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descripion { get; set; }
        public string Length { get; set; }
        public string Picture { get; set; }
        public DateTime Date { get; set; }
    }
}