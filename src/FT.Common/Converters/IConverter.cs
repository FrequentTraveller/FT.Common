using FT.Common.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FT.Common.Converters
{
    public interface IConverter<TEntity, TDto>
        where TDto : IDto
        where TEntity : IIdentifiable
    {
        Task<TDto> ConvertEntityAsync(TEntity e);

        Task<TEntity> ConvertDtoAsync(TDto d);

        ICollection<TDto> ConvertEntityCollection(ICollection<TEntity> e);

        ICollection<TEntity> ConvertDtoCollection(ICollection<TDto> d);
    }
}
