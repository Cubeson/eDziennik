using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edziennik
{
    public static class Utils
    {
        public static string DateStringInvert(string date)
        {
            var arr = date.Split("-");
            if(arr.Length < 2)
            {
                throw new ArgumentException("Input string date should have a day,month and year separated by '-'");
            }
            return arr[2] + "-" + arr[1] + "-" + arr[0];
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public Student(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public override string ToString()
        {
            return Id + ":" + Name + " " + Surname;
        }
    }
    public class _Task
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Date { get; set; } = "";
        public int TeacherId { get; set; }
        public int TaskTypeId { get; set; }
        public string TaskTypeReadableName { get; set; } = "";
        public _Task(int id, string name, string date, int teacherId, int taskTypeId, string taskTypeReadableName)
        {
            Id = id;
            Name = name;
            Date = date;
            TeacherId = teacherId;
            TaskTypeId = taskTypeId;
            TaskTypeReadableName = taskTypeReadableName;
        }
    }
    public class Mark
    {
        public int Id { get; private set; }
        public int StudentId { get; private set; }
        public int TaskId { get; private set; }
        public float Value { get; set; }
        public bool IsInDB { get; set; } = false;
        public bool toDelete { get; set; } = false;
        public Mark(int id, int studentId, int taskId, float value)
        {
            Id = id;
            StudentId = studentId;
            TaskId = taskId;
            Value = value;
        }
    }
}
