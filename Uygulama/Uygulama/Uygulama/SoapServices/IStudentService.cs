using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UygulamaModels;

namespace Uygulama.SoapServices
{
    public interface IStudentService
    {
        Task<String> LoginStudent(string userName, string password);
        Task<String> LoginStudentFTA(string userName);
		Task<List<StudentLectures>> studentLectures(string userName);
		Task<String> YemekhaneDetails(string userName);
		Task<List<WebNews>> GetWebNews();
		Task<List<WebAnnouncement>> webAnnouncements();
		Task<List<WebActivity>> webActivity();
		Task<List<WebStatistics>> webStatistics();
		Task<String> StudentInfo(string userName);
    }
}
