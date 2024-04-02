using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TimetableManagementConsoleProject
{
    public class JsonHelper
    {
        public string SerializeFacultyToJson(Faculty faculty)
        {
            return JsonConvert.SerializeObject(faculty);
        }
    }
}
