public interface IDepartmentService
{
    Task<ServiceResult<DepartmentDto>> GetByIdAsync(int id);
    Task<ServiceResult<List<DepartmentDto>>> GetAllAsync();
    Task<ServiceResult<DepartmentDto>> CreateAsync(DepartmentCreateDto dto);
    Task<ServiceResult<DepartmentDto>> UpdateAsync(int id, DepartmentUpdateDto dto);
    Task<ServiceResult<bool>> DeleteAsync(int id);
}