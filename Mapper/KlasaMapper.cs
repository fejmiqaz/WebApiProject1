using KursiDatabase.Models;
using KursiWebApi.DTOs;

namespace KursiWebApi.Mapper
{
    public static class KlasaMapper
    {
        public static Klasa ToModel(KlasaDto klasaDto)
        {
            return new Klasa
            {
                DataKrijimit = DateTime.Now,
                DataNdryshimit= DateTime.Now,
                Emri = klasaDto.Emri,
                Kapaciteti = klasaDto.Kapaciteti
            };
        }

        internal static object ToModel(object klasaDto)
        {
            throw new NotImplementedException();
        }
    }
}
