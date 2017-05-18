using System.Collections.Generic;
using System.ServiceModel;

namespace SoapService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Student GetStudent(string searchParam);

        [OperationContract]
        List<Student> GetStudents();

        [OperationContract]
        void AddUpdateStudent(Student student);
    }
}
