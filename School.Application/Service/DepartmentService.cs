public class DepartmentService : IDepartmentService
{
    private readonly List<DepartmentDto> _departments = new();

    public async Task<ServiceResult<DepartmentDto>> CreateAsync(DepartmentCreateDto dto)
    {
        var department = new DepartmentDto
        {
            Id = _departments.Count + 1,
            Name = dto.Name
        };
        _departments.Add(department);
        return new ServiceResult<DepartmentDto> { Data = department };
    }

    public async Task<ServiceResult<bool>> DeleteAsync(int id)
    {
        var dept = _departments.FirstOrDefault(d => d.Id == id);
        if (dept == null) return new ServiceResult<bool> { Success = false, Message = "Not found" };
        _departments.Remove(dept);
        return new ServiceResult<bool> { Data = true };
    }

    public async Task<ServiceResult<List<DepartmentDto>>> GetAllAsync()
    {
        return new ServiceResult<List<DepartmentDto>> { Data = _departments };
    }

    public async Task<ServiceResult<DepartmentDto>> GetByIdAsync(int id)
    {
        var dept = _departments.FirstOrDefault(d => d.Id == id);
        if (dept == null) return new ServiceResult<DepartmentDto> { Success = false, Message = "Not found" };
        return new ServiceResult<DepartmentDto> { Data = dept };
    }

    public async Task<ServiceResult<DepartmentDto>> UpdateAsync(int id, DepartmentUpdateDto dto)
    {
        var dept = _departments.FirstOrDefault(d => d.Id == id);
        if (dept == null) return new ServiceResult<DepartmentDto> { Success = false, Message = "Not found" };
        dept.Name = dto.Name;
        return new ServiceResult<DepartmentDto> { Data = dept };
    }
}