using System;

namespace POOF
{
    public class Log
    {
        public int idLog { get; set; }
        public int idUser { get; set; }
        public bool isWorking { get; set; }
        public DateTime dateTime { get; set; }
        public double temperature { get; set; }

        public Log() {}

        public Log(int pIdLog, int pIdUser, bool pIsWorking, DateTime pDT, double pTemp)
        {
            idLog = pIdLog;
            idUser = pIdUser;
            isWorking = pIsWorking;
            dateTime = pDT;
            temperature = pTemp;
        }
    }
}