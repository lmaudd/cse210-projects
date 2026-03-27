using System;
using System.Reflection.Metadata.Ecma335;

class MathAssigment : Assigment
{
    // Class Attributes
    private string _textbookSection;
    private string _problems;

     // Class Constructors 
    public MathAssigment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

     // Class Methods
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}