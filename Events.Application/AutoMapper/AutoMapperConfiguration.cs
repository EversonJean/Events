using AutoMapper;

namespace Events.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(x =>
                {
                    x.AddProfile(new DomainToDtoMapperProfile());
                    x.AddProfile(new DtoToDomainMapperProfile());
                }
            );
        }
    }
}
