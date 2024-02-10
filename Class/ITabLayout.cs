namespace VMatch.Class;
public interface ITabLayout
{
    string directoryPath { get; }
    string logPath { get; }

    bool checkDirectory();
    string getLiveTime();
    void logTime(string subject, bool useRealTime);
    bool isProblemsFinished();
    void attachClosingEvent();
}
