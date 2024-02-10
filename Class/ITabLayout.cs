using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMatch.Class;
public interface ITabLayout
{
    bool isQuestionsFinished();
    string getLiveTime();
    void attachClosingEvent();
}
