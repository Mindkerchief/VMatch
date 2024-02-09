using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMatch.Class;
public class TabLayoutModel
{
    private String questionTitle;
    private String question;
    private String questionAnswer;
    private String problemTitle;
    private String problem;

    public TabLayoutModel(string questionTitle, string question, 
        string questionAnswer, string problemTitle, string problem)
    {
        this.questionTitle = questionTitle;
        this.question = question;
        this.questionAnswer = questionAnswer;
        this.problemTitle = problemTitle;
        this.problem = problem;
    }

    public string QuestionTitle
    {
        get
        {
            return questionTitle;
        }
    }

    public string Question
    {
        get
        {
            return question;
        }
    }

    public string QuestionAnswer
    {
        get
        {
            return questionAnswer;
        }
    }

    public string ProblemTitle
    {
        get
        {
            return problemTitle;
        }
    }

    public string Problem
    {
        get
        {
            return problem;
        }
    }
}
