using AutoMapper;
using RentACar.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Drzave, Model.Drzave>();
            CreateMap<DrzaveUpsertRequest, Database.Drzave>();
            CreateMap<Database.Gradovi, Model.Gradovi>();
            CreateMap<GradoviUpsertRequest, Database.Gradovi>();
            CreateMap<Database.Lokacije, Model.Lokacije>();
            CreateMap<LokacijeUpsertRequest, Database.Lokacije>();
            CreateMap<Database.DodatnaOprema, Model.DodatnaOprema>();
            CreateMap<Database.Oprema, Model.Oprema>();
            CreateMap<OpremaUpsertRequest, Database.Oprema>();
            CreateMap<Database.Proizvodjaci, Model.Proizvodjaci>();
            CreateMap<ProizvodjaciUpsertRequest, Database.Proizvodjaci>();
            CreateMap<Database.Modeli, Model.Modeli>();
            CreateMap<ModeliUpsertRequest, Database.Modeli>();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.KategorijeVozila, Model.KategorijeVozila>();
            CreateMap<Database.Osiguranja, Model.Osiguranja>();
            CreateMap<OsiguranjaUpsertRequest, Database.Osiguranja>();
            CreateMap<Database.RegistracijeVozila, Model.RegistracijeVozila>();
            CreateMap<RegistracijeVozilaUpsertRequest, Database.RegistracijeVozila>();
            CreateMap<Database.Vozila, Model.Vozila>();
            CreateMap<VozilaUpsertRequest, Database.Vozila>();
            CreateMap<Database.Racuni, Model.Racuni>();
            CreateMap<RacuniUpsertRequest, Database.Racuni>();
            CreateMap<Database.Rezervacije, Model.Rezervacije>();
            CreateMap<RezervacijeUpsertRequest, Database.Rezervacije>();
            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<KorisniciUpsertRequest, Database.Korisnici>().ReverseMap();
            CreateMap<Database.Kupci, Model.Kupci>().ReverseMap();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>().ReverseMap();
            CreateMap<Database.Uloge, Model.Uloge>().ReverseMap();
            CreateMap<Database.Kupci, Model.Korisnici>().ReverseMap();
            CreateMap<KupciUpsertRequest, Database.Kupci>();
            CreateMap<Database.Novosti, Model.Novosti>().ReverseMap();
            CreateMap<NovostiUpsertRequest, Database.Novosti>();
            CreateMap<Database.Pretplate, Model.Pretplate>().ReverseMap();
            CreateMap<PretplateUpsertRequest, Database.Pretplate>();
            CreateMap<Database.Ocjene, Model.Ocjene>().ReverseMap();
            CreateMap<OcjeneUpsertRequest, Database.Ocjene>();
            CreateMap<Database.Notifikacije, Model.Notifikacije>().ReverseMap();
            CreateMap<NotifikacijeUpsertRequest, Database.Notifikacije>();
        }
    }
}
