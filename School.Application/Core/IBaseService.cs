public interface IBaseService<TDto, TCreate, TUpdate>
{
    Task<ServiceResult<TDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<TDto>>> GetAllAsync();
    Task<ServiceResult<TDto>> CreateAsync(TCreate dto);
    Task<ServiceResult<TDto>> UpdateAsync(int id, TUpdate dto);
    Task<ServiceResult<bool>> DeleteAsync(int id);
}