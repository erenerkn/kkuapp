using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using UIKit;
using Uygulama.SoapServices;
using UygulamaModels;
using Xamarin.Forms;

[assembly: Dependency(typeof(Uygulama.iOS.StudentService))]
namespace Uygulama.iOS
{
    public sealed class StudentService : IStudentService
    {
        tr.edu.kku.ogrenciportal.StudentPortalSystemAndroidService webService;
        public StudentService()
        {
            webService = new tr.edu.kku.ogrenciportal.StudentPortalSystemAndroidService();
        }
        public async Task<string> LoginStudent(string userName, string password)
        {
            return await Task.Run(() =>
            {
                var result = webService.StudentLogin2System(userName, password);
                return result;
            });
        }
        public async Task<string> LoginStudentFTA(string userName)
        {
            return await Task.Run(() =>
            {
                var result = webService.GetStudentAutomationLogin(userName);
                return result;
            });
        }
		public async Task<List<StudentLectures>> studentLectures(string userName)
		{
			var lectures = new List<StudentLectures>();
			return await Task.Run(() =>
			{
				var result = webService.GetStudentLectures(userName);
				foreach (var i in result)
				{
					lectures.Add(new StudentLectures
					{
						dersAdı = i.DERS_ADI,
						dersKodu = i.DERS_KODU,
						hocaAdı = i.OGR_GOR_AD,
						hocaSoyad = i.OGR_GOR_SOYAD
					});
				}
				return lectures;
			});
		}
		public async Task<string> YemekhaneDetails(string userName)
		{
			return await Task.Run(() =>
			{
				var result = webService.GetYemekhaneDetails(userName);
				return result;
			});
		}
		public async Task<List<WebNews>> GetWebNews()
		{
			var news = new List<WebNews>();
			return await Task.Run(() =>
			{
				var result = webService.GetWebHaber();
				foreach (var i in result)
				{
					news.Add(new WebNews
					{
						No = i.No,
						Header = i.Header
					});
				}
				return news;
			});
		}
		public async Task<List<WebAnnouncement>> webAnnouncements()
		{
			var announcements = new List<WebAnnouncement>();
			return await Task.Run(() =>
			{
				var result = webService.GetWebDuyuru();
				foreach (var i in result)
				{
					announcements.Add(new WebAnnouncement
					{
						No = i.No,
						Header = i.Header
					});
				}
				return announcements;
			});
		}
		public async Task<List<WebActivity>> webActivity()
		{
			var activity = new List<WebActivity>();
			return await Task.Run(() =>
			{
				var result = webService.GetWebEtkinlik();
				foreach (var i in result)
				{
					activity.Add(new WebActivity
					{
						activityNo = i.No,
						activityHeader = i.Header
					});
				}
				return activity;
			});
		}
		public async Task<List<WebStatistics>> webStatistics()
		{
			var dersler = new List<WebStatistics>();
			return await Task.Run(() =>
			{
				var result = webService.GetIstatistikData();

				foreach (var i in result)
				{
					dersler.Add(new WebStatistics
					{
						doktoraBayan = i.doktoraBayan,
						doktoraErkek = i.doktoraErkek,
						lisansBayan = i.lisansBayan,
						lisansErkek = i.lisansErkek,
						myoBayan = i.myoBayan,
						myoErkek = i.myoErkek,
						ylBayan = i.ylBayan,
						ylErkek = i.ylErkek
					});
				}
				return dersler;
			});
		}
		public async Task<string> StudentInfo(string userName)
		{
			return await Task.Run(() =>
			{
				var result = webService.GetStudentInfo(userName);
				return result;
			});

		}
	}
}