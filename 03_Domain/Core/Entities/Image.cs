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

        public Image() { }

        public void Validate()
        {
            if (String.IsNullOrEmpty(Descripion))
                throw new ArgumentException("Descrição é obrigatório");

            if (String.IsNullOrEmpty(Picture))
                throw new ArgumentException("Foto é obrigatório");

            if (String.IsNullOrEmpty(Title))
                throw new ArgumentException("Título é obrigatório");

            if (String.IsNullOrEmpty(Length))
                throw new ArgumentException("Tamanho da foto é obrigatório");
        }
    }
}