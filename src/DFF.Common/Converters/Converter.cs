using AutoMapper;
using DFF.Common.Mongo;
using DFF.Common.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFF.Common.Converters
{
    public class Converter<TRepository, TEntity, TDto> : IConverter<TEntity, TDto>
            where TDto : IDto
            where TEntity : IIdentifiable
            where TRepository : IMongoRepository<TEntity>
    {
        private MapperConfiguration _config;
        private readonly IMapper _mapper;
        private readonly TRepository _repository;

        protected Converter(TRepository repository)
        {
            _config = new MapperConfiguration(cfg =>
            {
                var map = CreateDefaultMapping(cfg.CreateMap<TEntity, TDto>());
                CreateReverseMapping(map.ReverseMap());
                CreateCustomMap(cfg);
            }
            );
            _mapper = _config.CreateMapper();
            _repository = repository;
        }

        protected virtual IMappingExpression<TEntity, TDto> CreateDefaultMapping(IMappingExpression<TEntity, TDto> mapping)
        {
            return mapping;
        }

        protected virtual IMappingExpression<TDto, TEntity> CreateReverseMapping(IMappingExpression<TDto, TEntity> mapping)
        {
            return mapping;
        }

        protected virtual void CreateCustomMap(IMapperConfigurationExpression cfg)
        {
            // nothing
        }

        public virtual async Task<TDto> ConvertEntityAsync(TEntity entity)
        {
            return await Task.Run(() => _mapper.Map<TDto>(entity));
        }

        public virtual async Task<TEntity> ConvertDtoAsync(TDto dto)
        {
            if (dto != null)
            {
                var entity = await _repository.GetAsync(dto.Id);
                if (entity != null)
                {
                    return _mapper.Map(dto, entity);
                }
            }
            return _mapper.Map<TEntity>(dto);
        }

        public virtual ICollection<TDto> ConvertEntityCollection(ICollection<TEntity> entity)
        {
            return entity.Select(x => Task.Run(() => ConvertEntityAsync(x)).Result).ToList() ?? new List<TDto>();
        }

        public virtual ICollection<TEntity> ConvertDtoCollection(ICollection<TDto> dto)
        {
            return dto.Select(x => Task.Run(() => ConvertDtoAsync(x)).Result).ToList() ?? new List<TEntity>();
        }
    }
}
