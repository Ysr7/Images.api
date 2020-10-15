using System;
using Core.Entities;

namespace API.Models
{
    public class ImageModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Descripion { get; set; }
        public string Length { get; set; }
        public string Picture { get; set; }
        public DateTime? Date { get; set; }

        public ImageModel() { }

        public ImageModel(Image image)
        {
            Id = image.Id;
            Title = image.Title;
            Descripion = image.Descripion;
            Length = image.Length;
            Picture = image.Picture;
            Date = image.Date;
        }
    }
}