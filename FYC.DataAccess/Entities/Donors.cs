using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYC.DataAccess.Entities
{
    public class Donors
    {
        public long DonorID { get; set; }        
        public string DonorName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public long ContactNumber { get; set; }
        public string EmailID { get; set; }
        public bool IsOrganization { get; set; }
        public bool IsIndividual { get; set; }
        public string IDCard { get; set; }
        public string ProfilePicture { get; set; }
        public string Attachment { get; set; }
        public string CreatedDate { get; set; }
        public string Extra { get; set; }
        public string Extra2 { get; set; }

    }
}
