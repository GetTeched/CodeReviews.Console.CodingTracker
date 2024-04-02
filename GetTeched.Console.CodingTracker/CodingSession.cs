﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_tracker;

public class CodingSession
{
    public int Id { get; set; }
    public string Date { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public string Duration { get; set; }
    //[NotMapped]
    //public string WeekNumber { get; set; }
    
}

//public class OtherCodingSession 
//{
//    public string FormattedDate { get; set; }
//    public string FormattedStartTime { get; set; }
//    public string FormattedEndTime { get; set;}
//}
