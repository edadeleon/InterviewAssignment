﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewAssignment.Models
{
    public class Classes
    {
        public string ClassID { get; set; }
        public int ClassCapacity { get; set; }
        public string CourseID { get; set; }
        public string CourseTitle { get; set; }
        public int Credits { get; set; }
        public int DayID { get; set; }
        public int StudentsEnrolled { get; set; }
        public string Modality { get; set; }
        public string SectionStatusID1 { get; set; }
        public float FinalCredits
        {
            get
            {
                return Credits / 10;
            }
        }
        public string DisplayModality
        {
            get
            {
                switch (Modality)
                {
                    case "80":
                        return "Hybrid";
                    case "50":
                        return "Virtual";
                    case "51":
                        return "Virtual Hybrid";
                    case "3C":
                        return "Online";
                    default:
                        return "Face to Face";
                }
            }
        }
        public string QuarterCode
        {
            get
            {
                int startIndex = ClassID.Length - 4;
                return ClassID.Substring(startIndex, 4);
            }
        }
        public string ItemNumber
        {
            get
            {
                return ClassID.Substring(1, 4);
            }

        }

        public string ClassStatus
        {
            get
            {
                if (!(SectionStatusID1 == "X"))
                {
                    if (StudentsEnrolled >= ClassCapacity)
                    {
                        return "Closed";
                    }
                    else
                    {
                        return "Open";
                    }
                }
                else
                {
                    return "Cancelled";
                }
            }
        }
    }
}
