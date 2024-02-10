using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMatch.Class;
public interface ITabLayout
{
    string directoryPath { get; }
    string logPath { get; }

    bool checkDirectory();
    string getLiveTime();
    void logTime(string subject, bool useRealTime);
    bool isQuestionsFinished();
    void attachClosingEvent();
}
