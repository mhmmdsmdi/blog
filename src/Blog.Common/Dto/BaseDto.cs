using Mapster;

namespace Blog.Common.Dto;

public class BaseDto<TDto, TSource>
    where TDto : class, new()
    where TSource : class, new()

{
    private readonly TypeAdapterSetter<TSource, TDto> _adapterSetter;

    public TSource ToSource()
    {
        return this.Adapt<TSource>(_adapterSetter.Config);
    }

    public TDto FromSource(TSource source)
    {
        return source.Adapt<TDto>(_adapterSetter.Config);
    }

    public BaseDto()
    {
        _adapterSetter = TypeAdapterConfig<TSource, TDto>
            .NewConfig();
    }

    public void CreateMappings()
    {
        CustomMappings(_adapterSetter);
    }

    protected virtual void CustomMappings(TypeAdapterSetter<TSource, TDto> config)
    {
    }
}