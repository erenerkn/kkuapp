using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uygulama.PCL.KirikkkaleUni;

namespace Uygulama.PCL
{
    
    public class Class1
    {

        public void Login()
        {
            StudentLogin2SystemRequest req = new StudentLogin2SystemRequest();
            StudentLogin2SystemRequestBody reqBody = new StudentLogin2SystemRequestBody
            {
                
            };

            req.Body = reqBody;

            StudentPortalSystemAndroidServiceSoapClient _client = new StudentPortalSystemAndroidServiceSoapClient();
            _client.StudentLogin2SystemAsync("150255047", "th3powerqq");
            
        }

        
        KirikkkaleUni.StudentLogin2SystemResponse res = new StudentLogin2SystemResponse();
        StudentLogin2SystemResponseBody resBody = new StudentLogin2SystemResponseBody();
        
        
    }
}
