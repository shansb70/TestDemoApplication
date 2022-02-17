using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Repository
    {
        internal static void Create(UserDetail userDetail)
        {
            _ = new UserDetail
            {
                FirstName = userDetail.FirstName,
                LastName = userDetail.LastName
            };

      
            List<UserDetail> fdata = new List<UserDetail>();
            fdata.Add(userDetail);
            String json = JsonConvert.SerializeObject(fdata.ToArray());
            File.WriteAllText(@"D:\TEST2.CSV", json);


        }
    }
}
