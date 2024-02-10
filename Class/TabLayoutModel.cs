namespace VMatch.Class;
public class TabLayoutModel
{
    private String questionTitle;
    private String question;
    private String questionAnswer;
    private String problemTitle;
    private String problem;
    private bool isFinished;

    public TabLayoutModel(string questionTitle, string question, 
        string questionAnswer, string problemTitle, string problem)
    {
        this.questionTitle = questionTitle;
        this.question = question;
        this.questionAnswer = questionAnswer;
        this.problemTitle = problemTitle;
        this.problem = problem;
        this.IsFinished = false;
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

    public bool IsFinished
    {
        get
        {
            return isFinished;
        }

        set
        {
            isFinished = value;
        }
    }
}
