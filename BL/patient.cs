using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms.BL
{
    class patient
    {
        public string patientName;
        public int patientAge;
        public string patientDisease;
        public string patientBlood;
        public string patientCnic;
        public int patientId;
        public string patientGender;
        public string patientMobile;
        public string patientAddress;

        public patient( string patientName,int patientAge,string patientDisease,string patientBlood,string patientCnic,int patientId,string patientGender,string patientMobile,string patientAddress)
        {
            this.patientName = patientName;
            this.patientAge = patientAge;
            this.patientDisease = patientDisease;
            this.patientBlood = patientBlood;
            this.patientCnic = patientCnic;
            this.patientId = patientId;
            this.patientGender = patientGender;
            this.patientMobile = patientMobile;
            this.patientAddress = patientAddress;
        }
    }
}
