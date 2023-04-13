using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.BL
{
    class doctor
    {
        public string doctorName;
        public int doctorAge;
        public string doctorGender;
        public string doctorSpecialization;
        public int doctorId;
        public string doctorAddress;
        public string doctorBlood;
        public string doctorMobile;
        public string doctorMail;

        public doctor(string doctorName,int doctorAge,string doctorGender,string doctorSpecialization,int doctorId,string doctorAddress,string doctorBlood,string doctorMail,string doctorMobile)
        {
            this.doctorName = doctorName;
            this.doctorAge = doctorAge;
            this.doctorSpecialization = doctorSpecialization;
            this.doctorId = doctorId;
            this.doctorAddress = doctorAddress;
            this.doctorBlood = doctorBlood;
            this.doctorMobile = doctorMobile;
            this.doctorMail = doctorMail;
            this.doctorGender = doctorGender;
        }
    }
}
