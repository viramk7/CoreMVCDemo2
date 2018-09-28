namespace CoreMVCDemo2.Services.Student
{
    public interface IStudentService : IEntityService<Models.Student>
    {
        Models.Student GetById(long id);
    }
}
