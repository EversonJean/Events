using AutoMapper;

namespace Events.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile(new DomainToDtoMapperProfile());
                x.AddProfile(new DtoToDomainMapperProfile());
            });
        }
    }
}
