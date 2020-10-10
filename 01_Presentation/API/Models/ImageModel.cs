using System;
using Core.Entities;

namespace API.Models
{
    public class ImageModel
    {
        public int? Id { get; set; }
        public string Descripion { get; set; }
        public int Length { get; set; }
        public string Picture { get; set; }
        public DateTime? Date { get; set; }

        public ImageModel() { }

        public ImageModel(Image image)
        {
            Id = image.Id;
            Descripion = image.Descripion;
            Length = image.Length;
            Picture = image.Picture;
            Date = image.Date;
        }
    }
}