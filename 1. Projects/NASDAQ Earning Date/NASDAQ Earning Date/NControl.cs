﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASDAQ_Earning_Date
{
    class NControl
    {
        public static string symbolListAdd = mainDirectory + @"0.VolAnalysis\SymbolList.txt";
        public static string symbolOutputAdd = mainDirectory +  @"0.VolAnalysis\EarningsNASDAQ.txt";
        public const string mainDirectory = @"C:\Users\Samuel\Documents\dfkjdf\";

        public static int separateDay = 40;

        public static string RerunCode = mainDirectory + @"0.VolAnalysis\gfs\fh.R";

        public static DateTime StartDate = new DateTime(2010,1,1);

        public static string OtherShocksDate = mainDirectory + @"0.VolAnalysis\OtherDates.txt";
    }
}